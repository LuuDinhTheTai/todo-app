using todo_app.controller;
using todo_app.entity;
using todo_app.service;

namespace todo_app;

public partial class Form1 : Form
{
    private Controller _controller;
    private TagService _tagService;
    private TodoService _todoService;

    private LoggedInAccount _loggedInAccount;

    private Tag? _currentTag = null;
    private List<Todo>? _currentTodos = null;

    // DateTime picker overlay for DueDate
    private DateTimePicker? _dueDatePicker;
    private int _dueDateRowIndex = -1;
    private int _dueDateColIndex = -1;
    private bool _isDuePickerDroppedDown = false; // NEW: track calendar open state

    public Form1(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
        _tagService = controller.TagService;
        _todoService = controller.TodoService;

        _loggedInAccount = controller.LoggedInAccount;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        if (!_loggedInAccount.IsLoggedIn())
        {
            var loginForm = new LoginForm(_controller);
            loginForm.ShowDialog();
        }

        if (!_loggedInAccount.IsLoggedIn())
        {
            this.BeginInvoke(new Action(() => this.Close()));
            return;
        }

        ConfigTagDataGridView();
        ConfigTodoDataGridView();

        // Init date picker for DueDate column
        InitDueDatePicker();

        // Show calendar when clicking DueDate cell
        todoDataGridView.CellClick += todoDataGridView_CellClick;
        todoDataGridView.Scroll += (_, __) => HideDueDatePicker();
        todoDataGridView.ColumnWidthChanged += (_, __) => HideDueDatePicker();

        LoadTags();
        LoadTodos();
    }

    // CONFIGURATION
    private void ConfigTodoDataGridView()
    {
        todoDataGridView.AutoGenerateColumns = false;
        if (todoDataGridView.Columns["colStatus"] != null)
        {
            todoDataGridView.Columns["colStatus"].DataPropertyName = "IsDone";
        }

        if (todoDataGridView.Columns["colContent"] != null)
        {
            todoDataGridView.Columns["colContent"].DataPropertyName = "Content";
        }

        // Prevent manual typing in DueDate cell; use the calendar picker instead
        if (todoDataGridView.Columns["colDueDate"] != null)
        {
            todoDataGridView.Columns["colDueDate"].ReadOnly = true;
        }

        if (todoDataGridView.Columns["colDelete"] != null)
        {

        }
    }

    private void ConfigTagDataGridView()
    {
        tagDataGridView.AutoGenerateColumns = false;
        if (tagDataGridView.Columns["colTag"] != null)
        {
            tagDataGridView.Columns["colTag"].DataPropertyName = "Name";
        }
    }

    // DateTimePicker setup
    private void InitDueDatePicker()
    {
        _dueDatePicker = new DateTimePicker
        {
            Format = DateTimePickerFormat.Custom,
            CustomFormat = "dd/MM/yyyy HH:mm",
            ShowCheckBox = true,
            Visible = false
        };

        // Track drop-down state to avoid committing while navigating months
        _dueDatePicker.DropDown += (_, __) => _isDuePickerDroppedDown = true;
        _dueDatePicker.CloseUp += (_, __) =>
        {
            _isDuePickerDroppedDown = false;
            CommitDueDateFromPicker(); // commit once user closes the calendar
        };

        // Commit when not in drop-down (covers keyboard edits and checkbox toggle)
        _dueDatePicker.ValueChanged += (_, __) =>
        {
            if (_dueDatePicker.Visible && !_isDuePickerDroppedDown)
            {
                CommitDueDateFromPicker();
            }
        };

        todoDataGridView.Controls.Add(_dueDatePicker);
    }

    private void ShowDueDatePicker(int rowIndex, int colIndex)
    {
        if (_dueDatePicker == null) return;

        var rect = todoDataGridView.GetCellDisplayRectangle(colIndex, rowIndex, true);
        _dueDatePicker.Bounds = new System.Drawing.Rectangle(rect.X, rect.Y, rect.Width, rect.Height);

        var todo = todoDataGridView.Rows[rowIndex].DataBoundItem as Todo;
        if (todo != null && todo.DueDate.HasValue)
        {
            _dueDatePicker.Value = todo.DueDate.Value;
            _dueDatePicker.Checked = true;
        }
        else
        {
            _dueDatePicker.Value = DateTime.Now;
            _dueDatePicker.Checked = false; // unchecked => null due date
        }

        _dueDateRowIndex = rowIndex;
        _dueDateColIndex = colIndex;
        _isDuePickerDroppedDown = false; // reset state when showing
        _dueDatePicker.Visible = true;
        _dueDatePicker.BringToFront();
        _dueDatePicker.Focus();
    }

    private void HideDueDatePicker()
    {
        if (_dueDatePicker == null) return;
        _dueDatePicker.Visible = false;
        _isDuePickerDroppedDown = false;
        _dueDateRowIndex = _dueDateColIndex = -1;
    }

    private void CommitDueDateFromPicker()
    {
        if (_dueDatePicker == null || _dueDateRowIndex < 0) return;

        var row = todoDataGridView.Rows[_dueDateRowIndex];
        var todo = row.DataBoundItem as Todo;
        if (todo == null) { HideDueDatePicker(); return; }

        // Apply selection (unchecked means remove due date)
        todo.DueDate = _dueDatePicker.Checked ? _dueDatePicker.Value : null;

        // Persist and refresh
        _todoService.Update(todo);
        LoadTodos();

        HideDueDatePicker();
    }

    // HANDLE EVENT
    private void btnCreateTodo_Click(object sender, EventArgs e)
    {
        string content = tBContent.Text;
        if (string.IsNullOrEmpty(content))
        {
            return;
        }

        if (_currentTag == null)
        {
            return;
        }

        _todoService.Create(content, _currentTag);

        tBContent.Clear();
        LoadTodos();
    }

    private void btnCreateTag_Click(object sender, EventArgs e)
    {
        string tagName = tBTagName.Text;
        _tagService.Create(tagName);

        tBTagName.Clear();
        LoadTags();
    }

    private void todoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        var column = todoDataGridView.Columns[e.ColumnIndex];

        if (column is DataGridViewButtonColumn && column.Name == "colDelete")
        {
            var todo = todoDataGridView.Rows[e.RowIndex].DataBoundItem as Todo;
            if (todo == null)
                return;

            var result = MessageBox.Show("Xóa tác vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            _todoService.Delete(todo.Id);
            LoadTodos();
        }
        else if (column is DataGridViewCheckBoxColumn && column.Name == "colStatus")
        {
            todoDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            todoDataGridView_CellValueChanged(sender, e);
        }
    }

    // Open calendar on clicking DueDate cell
    private void todoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var col = todoDataGridView.Columns[e.ColumnIndex];
        if (col != null && col.Name == "colDueDate")
        {
            ShowDueDatePicker(e.RowIndex, e.ColumnIndex);
        }
    }

    private void todoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        var colName = todoDataGridView.Columns[e.ColumnIndex].Name;
        if (colName == "colStatus" || colName == "colDueDate")
        {
            var todo = todoDataGridView.Rows[e.RowIndex].DataBoundItem as Todo;
            if (todo == null)
                return;

            _todoService.Update(todo);

            LoadTodos();
        }
    }

    private void LoadTags()
    {
        var tags = _tagService.FindAll();
        tagDataGridView.DataSource = tags.OrderBy(t => t.Name).ToList();
        _currentTag = tags.FirstOrDefault();
    }

    private void LoadTodos()
    {
        if (_currentTag == null)
        {
            return;
        }

        _currentTodos = _todoService.FindByTagId(_currentTag.Id);
        todoDataGridView.DataSource = _currentTodos
            .OrderBy(t => t.IsDone)
            .ThenBy(t => t.DueDate ?? DateTime.MaxValue)
            .ToList();
    }

    private void tagDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        int rowIndex = e.RowIndex;
        int colIndex = e.ColumnIndex;

        if (rowIndex < 0 || colIndex < 0)
        {
            return;
        }

        var cell = tagDataGridView.Rows[rowIndex].Cells[colIndex];
        var value = cell.Value;

        if (value is string)
        {
            _currentTag = _tagService.FindByName((string)value);
        }

        LoadTodos();
    }

    // Tô đỏ ô Hạn chót nếu còn ≤ 1 ngày (bao gồm quá hạn)
    private void todoDataGridView_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var grid = this.todoDataGridView;
        var column = grid.Columns[e.ColumnIndex];
        if (column == null || column.Name != "colDueDate") return;

        var row = grid.Rows[e.RowIndex];
        var data = row.DataBoundItem as Todo;
        if (data == null) return;

        // Reset default color
        e.CellStyle.ForeColor = grid.DefaultCellStyle.ForeColor;
        e.CellStyle.SelectionForeColor = grid.DefaultCellStyle.SelectionForeColor;

        // red color if due date is within 1 day and not done
        if (!data.IsDone && data.DueDate.HasValue)
        {
            var now = DateTime.Now;
            var due = data.DueDate.Value;

            if (due <= now.AddDays(1))
            {
                e.CellStyle.ForeColor = System.Drawing.Color.Red;
                e.CellStyle.SelectionForeColor = System.Drawing.Color.Red;
            }
        }
    }
}