using todo_app.controller;
using todo_app.entity;
using todo_app.service;
using todo_app.view;

namespace todo_app;

public partial class Form1 : Form
{
    private Controller _controller;
    private TagService _tagService;
    private TodoService _todoService;
    private FileService _fileService;

    private LoggedInAccount _loggedInAccount;

    private Tag? _currentTag = null;
    private List<Todo>? _currentTodos = null;

    public Form1(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
        _tagService = controller.TagService;
        _todoService = controller.TodoService;
        _fileService = controller.FileService;

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
        else if(column is DataGridViewTextBoxColumn && column.Name == "colContent")
        {
            Todo currentTodo = todoDataGridView.Rows[e.RowIndex].DataBoundItem as Todo;
            if (currentTodo == null)
                return;

            var formNote = new Note(currentTodo, _controller);
            formNote.ShowDialog();
        }
    }

    private void todoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        if (todoDataGridView.Columns[e.ColumnIndex].Name == "colStatus")
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
        todoDataGridView.DataSource = _currentTodos.OrderBy(t => t.IsDone).ToList();
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

    private void btnExportFileExcel_Click(object sender, EventArgs e)
    {
        sfdExcel.Filter = "Excel Workbook|*.xlsx";
        sfdExcel.Title = "Chọn vị trí lưu file Excel";
        sfdExcel.FileName = $"Todo_By_Tags_{DateTime.Now:yyyyMMdd}.xlsx";
        if (sfdExcel.ShowDialog() == DialogResult.OK)
        {
            if (_fileService.ExportFileExcel(sfdExcel.FileName))
            {
                MessageBox.Show("Xuất file Excel thành công!\nĐã lưu tại: " + sfdExcel.FileName,
                        "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    private void btnShowChart_Click(object sender, EventArgs e)
    {    
        var chartForm = new view.ChartForm(_controller, _currentTag!);
        chartForm.ShowDialog();
    }

}