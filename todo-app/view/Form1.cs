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

        // đăng ký thêm event để xử lý thay đổi combobox / checkbox trong grid
        todoDataGridView.CellValueChanged += todoDataGridView_CellValueChanged;
        todoDataGridView.CurrentCellDirtyStateChanged += todoDataGridView_CurrentCellDirtyStateChanged;

        LoadTags();
        LoadTodos();
    }

    // ======================
    // CONFIGURATION
    // ======================
    private void ConfigTodoDataGridView()
    {
        // chúng ta không còn bind DataSource trực tiếp nữa,
        // nên DataPropertyName không còn quá quan trọng.
        // Nhưng giữ lại cũng không sao.
        todoDataGridView.AutoGenerateColumns = false;

        if (todoDataGridView.Columns["colStatus"] != null)
        {
            todoDataGridView.Columns["colStatus"].DataPropertyName = "IsDone";
        }

        if (todoDataGridView.Columns["colContent"] != null)
        {
            todoDataGridView.Columns["colContent"].DataPropertyName = "Content";
        }

        if (todoDataGridView.Columns["colPriority"] != null)
        {
            // không bind trực tiếp priority vì ta hiển thị text "1 - Thấp"...,
            // nên để trống DataPropertyName cho colPriority là ok.
        }

        if (todoDataGridView.Columns["colDelete"] != null)
        {
            // button delete không cần DataPropertyName
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

    // ======================
    // HANDLE EVENT (BUTTONS)
    // ======================
    private void btnCreateTodo_Click(object sender, EventArgs e)
    {
        string content = tBContent.Text;
        if (string.IsNullOrWhiteSpace(content))
        {
            return;
        }

        if (_currentTag == null)
        {
            return;
        }

        // tạo todo mới với priority mặc định 1 (Thấp)
        _todoService.Create(content, _currentTag, 1);

        tBContent.Clear();
        LoadTodos();
    }

    private void btnCreateTag_Click(object sender, EventArgs e)
    {
        string tagName = tBTagName.Text;
        if (string.IsNullOrWhiteSpace(tagName))
        {
            return;
        }

        _tagService.Create(tagName);

        tBTagName.Clear();
        LoadTags();
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
                MessageBox.Show(
                    "Xuất file Excel thành công!\nĐã lưu tại: " + sfdExcel.FileName,
                    "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information
                );
            }
        }
    }

    // ======================
    // HANDLE EVENT (GRID)
    // ======================

    // click vào ô (xóa / mở Note)
    private void todoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        var column = todoDataGridView.Columns[e.ColumnIndex];
        var row = todoDataGridView.Rows[e.RowIndex];

        // lấy todoId đã lưu ở LoadTodos()
        if (row.Tag is not int todoId)
            return;

        if (column is DataGridViewButtonColumn && column.Name == "colDelete")
        {
            var result = MessageBox.Show(
                "Xóa tác vụ này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result != DialogResult.Yes)
                return;

            _todoService.Delete(todoId);
            LoadTodos();
        }
        else if (column is DataGridViewTextBoxColumn && column.Name == "colContent")
        {
            // mở form Note với todo tương ứng
            var currentTodo = _todoService.FindById(todoId);
            if (currentTodo == null)
                return;

            var formNote = new Note(currentTodo, _controller);
            formNote.ShowDialog();

            // nếu Note thay đổi, reload lại
            LoadTodos();
        }
        else if (column is DataGridViewCheckBoxColumn && column.Name == "colStatus")
        {
            // Checkbox là trường hợp đặc biệt:
            // DataGridView chỉ commit khi ta yêu cầu, nên ta chủ động commit và xử lý tại CellValueChanged
            todoDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }

    // ép commit thay đổi ngay khi chọn trong combobox / checkbox
    private void todoDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
    {
        if (todoDataGridView.IsCurrentCellDirty)
        {
            todoDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }
    }

    // bất cứ khi nào giá trị ô thay đổi (checkbox IsDone, combobox Priority)
    private void todoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        var changedCol = todoDataGridView.Columns[e.ColumnIndex].Name;
        var row = todoDataGridView.Rows[e.RowIndex];

        if (row.Tag is not int todoId)
            return;

        // 1. Người đổi trạng thái hoàn thành (colStatus)
        if (changedCol == "colStatus")
        {
            bool newDone = Convert.ToBoolean(row.Cells["colStatus"].Value);

            // lấy todo hiện tại từ service
            var todo = _todoService.FindById(todoId);
            if (todo == null)
                return;

            todo.IsDone = newDone;

            _todoService.Update(todo);

            LoadTodos();
            return;
        }

        // 2. Người đổi mức ưu tiên (colPriority)
        if (changedCol == "colPriority")
        {
            string picked = row.Cells["colPriority"].Value?.ToString() ?? "1 - Thấp";
            int newPriority =
                picked.StartsWith("3") ? 3 :
                picked.StartsWith("2") ? 2 :
                1;

            _todoService.UpdateTodoPriority(todoId, newPriority);

            LoadTodos();
            return;
        }
    }

    // click chọn tag bên trái -> đổi _currentTag -> load todo tương ứng
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

        if (value is string tagName)
        {
            _currentTag = _tagService.FindByName(tagName);
        }

        LoadTodos();
    }

    // ======================
    // RENDER DATA
    // ======================
    private void LoadTags()
    {
        var tags = _tagService.FindAll();
        tagDataGridView.DataSource = tags
            .OrderBy(t => t.Name)
            .ToList();

        if (_currentTag == null)
        {
            _currentTag = tags.FirstOrDefault();
        }

        // cập nhật label hiển thị tên user
        lblUsername.Text = "Hi, " + _loggedInAccount.GetUsername();
    }

    private void LoadTodos()
    {
        if (_currentTag == null)
        {
            // nếu chưa chọn tag thì clear bảng bên phải
            todoDataGridView.DataSource = null;
            todoDataGridView.Rows.Clear();
            lblTagName.Text = "Tác vụ";
            return;
        }

        _currentTodos = _todoService.FindByTagId(_currentTag.Id);

        // sắp xếp: ưu tiên cao trước, rồi chưa hoàn thành trước
        var displayList = _currentTodos
            .OrderByDescending(t => t.Priority)
            .ThenBy(t => t.IsDone)
            .ToList();

        // cập nhật label tên tag đang xem
        lblTagName.Text = _currentTag.Name;

        // clear grid cũ
        todoDataGridView.DataSource = null;
        todoDataGridView.Rows.Clear();

        foreach (var todo in displayList)
        {
            int rowIndex = todoDataGridView.Rows.Add();
            var row = todoDataGridView.Rows[rowIndex];

            // trạng thái
            row.Cells["colStatus"].Value = todo.IsDone;

            // nội dung
            row.Cells["colContent"].Value = todo.Content;

            // priority -> text hiển thị
            row.Cells["colPriority"].Value = todo.Priority switch
            {
                3 => "3 - Cao",
                2 => "2 - Trung bình",
                _ => "1 - Thấp"
            };

            // nút xóa
            row.Cells["colDelete"].Value = "Xóa";

            // ghi nhớ id todo để thao tác sau này
            row.Tag = todo.Id;
        }
    }
}
