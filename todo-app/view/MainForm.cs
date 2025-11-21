using System.Windows.Forms;
using todo_app.controller;
using todo_app.entity;
using todo_app.exception;
using todo_app.service;
using todo_app.view;

namespace todo_app;

public partial class MainForm : Form
{
    private Controller _controller;
    private TagService _tagService;
    private TodoService _todoService;
    private FileService _fileService;

    private LoginForm _loginForm;

    private LoggedInAccount _loggedInAccount;

    private Tag? _currentTag = null;
    private Todo? _currentTodo = null;
    public MainForm()
    {
        InitializeComponent();
    }

    public MainForm(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
        _tagService = controller.TagService;
        _todoService = controller.TodoService;
        _fileService = controller.FileService;
        _loggedInAccount = controller.LoggedInAccount;
    }

    public void Reload()
    {
        LoadTags();
        HideRightSideBar();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        if (!_loggedInAccount.IsLoggedIn())
        {
            if (_controller.RememberMeService.Load(out var username, out var password))
            {
                try
                {
                    _controller.AccountService.Login(username, password);
                }
                catch
                {
                    _controller.RememberMeService.Clear();
                }
            }
        }

        if (!_loggedInAccount.IsLoggedIn())
        {
            var loginForm = new LoginForm(_controller);
            loginForm.ShowDialog();
        }

        if (!_loggedInAccount.IsLoggedIn())
        {
            Application.Exit();
        }

        LoadTags();

        HideRightSideBar();
    }

    private void btnToggleLeftSideBar_Click(object sender, EventArgs e)
    {
        panelLeftSideBar.Width = panelLeftSideBar.Width == 0 ? 250 : 0;
    }

    private void LoadTags()
    {
        var tags = _tagService.FindAll();
        dgvTags.DataSource = tags.OrderBy(t => t.Name).ToList();

        try
        {
            dgvTags.Columns["Id"].Visible = false;
            dgvTags.Columns["AccountId"].Visible = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void LoadTodos(List<Todo> datasource)
    {
        if (_currentTag == null)
        {
            dgvTodos.DataSource = null;
            return;
        }

        dgvTodos.DataSource = null;
        dgvTodos.DataSource = datasource.OrderBy(t => t.IsDone).ToList();

        try
        {
            dgvTodos.Columns["Id"].Visible = false;
            dgvTodos.Columns["Note"].Visible = false;
            dgvTodos.Columns["DueDate"].Visible = false;
            dgvTodos.Columns["IsImportant"].Visible = false;
            dgvTodos.Columns["ParentId"].Visible = false;

            dgvTodos.Columns["IsDone"].Width = 50;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void LoadSubTodos(List<Todo> datasource)
    {
        if (_currentTodo == null)
        {
            dgvSubTodo.DataSource = null;
            return;
        }

        dgvSubTodo.DataSource = null;
        dgvSubTodo.DataSource = datasource.OrderBy(t => t.IsDone).ToList();

        try
        {
            if (dgvSubTodo.Columns.Contains("Content")) dgvSubTodo.Columns["Content"].FillWeight = 80;
            dgvSubTodo.Columns["colDelete"].DisplayIndex = dgvSubTodo.Columns.Count - 1;
            if (dgvSubTodo.Columns.Contains("Id")) dgvSubTodo.Columns["Id"].Visible = false;
            if (dgvSubTodo.Columns.Contains("ParentId")) dgvSubTodo.Columns["ParentId"].Visible = false;
            if (dgvSubTodo.Columns.Contains("Note")) dgvSubTodo.Columns["Note"].Visible = false;
            if (dgvSubTodo.Columns.Contains("DueDate")) dgvSubTodo.Columns["DueDate"].Visible = false;
            if (dgvSubTodo.Columns.Contains("IsImportant")) dgvSubTodo.Columns["IsImportant"].Visible = false;
            if (dgvSubTodo.Columns.Contains("IsDone"))
            {
                dgvSubTodo.Columns["IsDone"].Width = 30;
                dgvSubTodo.Columns["IsDone"].FillWeight = 20;

            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private void tbCreateTag_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string tagName = tbCreateTag.Text;
            _tagService.Create(tagName);

            tbCreateTag.Clear();
            LoadTags();
        }
    }

    private void tbCreateTodo_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            CreateTodo();
        }
    }

    private void dgvTags_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        var selectedTag = dgvTags.Rows[e.RowIndex].DataBoundItem as Tag;

        if (selectedTag == null)
        {
            return;
        }

        _currentTag = selectedTag;
        lbTagName.Text = _currentTag.Name;
        List<Todo> todos = _todoService.FindByTagId(_currentTag.Id);
        LoadTodos(todos);
    }

    private void btnHideRightSideBar_Click(object sender, EventArgs e)
    {
        HideRightSideBar();
    }

    private void ShowRightSideBar(Todo todo)
    {

        if (todo == null)
        {
            return;
        }
        cbStatusTodo.Checked = todo.IsDone;
        lbCurrentTodoName.Text = todo.Content;
        dtpCurrentTodoDueDate.Value = todo.DueDate ?? DateTime.Now;
        tbCurrentTodoNote.Text = todo.Note;

        lbCurrentTodoTagName.Text = _tagService.FindByTodoId(todo.Id).Name;

        panelRightSideBar.Width = 300;


    }

    private void HideRightSideBar()
    {
        panelRightSideBar.Width = 0;
    }

    private void dgvTodos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        var selectedTodo = dgvTodos.Rows[e.RowIndex].DataBoundItem as Todo;

        if (selectedTodo == null)
        {
            return;
        }

        _currentTodo = selectedTodo;

        List<Todo> subTodos = _todoService.FindByParentId(_currentTodo.Id);
        LoadSubTodos(subTodos);

        ShowRightSideBar(selectedTodo);
    }

    private void tbCreateTodo_TextChanged(object sender, EventArgs e)
    {
        if (tbCreateTodo.Text.Length > 0)
        {
            btnCreateTodo.Enabled = true;
        }
        else
        {
            btnCreateTodo.Enabled = false;
        }
    }

    private void btnCreateTodo_Click(object sender, EventArgs e)
    {
        CreateTodo();
    }

    private void CreateTodo()
    {
        string content = tbCreateTodo.Text;

        List<Todo> existingTodos = _todoService.FindByTagId(_currentTag!.Id);
        bool isDuplicate = existingTodos.Any(todo => todo.Content.Trim().Equals(content.Trim(), StringComparison.OrdinalIgnoreCase));

        if (isDuplicate)
        {
            MessageBox.Show("Tác vụ này đã tồn tại trong thẻ hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        DateTime dueDate = dtpCreateTodo.Value;
        _todoService.Create(content, dueDate, _currentTag);

        tbCreateTodo.Clear();
        List<Todo> todos = _todoService.FindByTagId(_currentTag!.Id);
        LoadTodos(todos);
    }

    private void btnDeleteTodo_Click(object sender, EventArgs e)
    {
        if (_currentTodo == null)
        {
            return;
        }

        _todoService.Delete(_currentTodo.Id);
        HideRightSideBar();
        List<Todo> todos = _todoService.FindByTagId(_currentTag!.Id);
        LoadTodos(todos);
    }

    private void btnUserMenu_Click(object sender, EventArgs e)
    {
        Control control = sender as Control;

        Point menuPosition = new Point(
            0,
            control.Height
        );

        if (_loggedInAccount.IsLoggedIn())
        {
            cmsUserMenu.Items["miLogin"].Visible = false;
            cmsUserMenu.Items["miRegister"].Visible = false;
        }
        if (!_loggedInAccount.IsLoggedIn())
        {
            cmsUserMenu.Items["miExportFile"].Visible = false;
            cmsUserMenu.Items["miLogout"].Visible = false;
            cmsUserMenu.Items["miChangePassword"].Visible = false;
        }

        cmsUserMenu.Show(control, menuPosition);
    }

    private void miExportFile_Click(object sender, EventArgs e)
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

    private void btnTagMenu_Click(object sender, EventArgs e)
    {
        Control control = sender as Control;

        Point menuPosition = new Point(
            0,
            control.Height
        );

        cmsTagMenu.Show(control, menuPosition);
    }

    private void miDrawChart_Click(object sender, EventArgs e)
    {
        var chartForm = new view.ChartForm(_controller, _currentTag!);
        chartForm.ShowDialog();
    }

    private void miDeleteTag_Click(object sender, EventArgs e)
    {
        _tagService.Delete(_currentTag.Id);
        _currentTag = null;

        LoadTags();
        LoadTodos(null);
    }

    private void cbStatusTodo_CheckedChanged(object sender, EventArgs e)
    {
        if (_currentTodo == null)
        {
            return;
        }
        bool isDone = cbStatusTodo.Checked;
        _todoService.CheckTodo(_currentTodo.Id, isDone);
        List<Todo> todos = _todoService.FindByTagId(_currentTag!.Id);
        LoadTodos(todos);
    }

    private void dgvTodos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        if (dgvTodos.Columns[e.ColumnIndex].Name != "IsDone")
        {
            return;
        }

        var selectedTodo = dgvTodos.Rows[e.RowIndex].DataBoundItem as Todo;
        if (selectedTodo == null)
        {
            return;
        }

        _todoService.CheckTodo(selectedTodo.Id, !selectedTodo.IsDone);

        List<Todo> todos = _todoService.FindByTagId(_currentTag!.Id);
        LoadTodos(todos);
    }

    private void dtpCurrentTodoDueDate_ValueChanged(object sender, EventArgs e)
    {
        if (_currentTodo == null)
        {
            return;
        }

        DateTime dueDate = dtpCurrentTodoDueDate.Value;
        _todoService.UpdateDueDate(_currentTodo.Id, dueDate);
    }

    private void tbCurrentTodoNote_Leave(object sender, EventArgs e)
    {
        if (_currentTodo == null)
        {
            return;
        }

        string note = tbCurrentTodoNote.Text;

        if (_currentTodo.Note != note)
        {
            _todoService.UpdateNote(_currentTodo.Id, note);
            _currentTodo.Note = note;
        }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
        string keyword = tbSearchTodo.Text;
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return;
        }

        List<Todo> todos = _todoService.SearchTodos(keyword);
        LoadTodos(todos);
    }

    private void miLogout_Click(object sender, EventArgs e)
    {
        _controller.RememberMeService.Clear();

        _loggedInAccount.Logout();
        Hide();
        LoginForm loginForm = new LoginForm(_controller);
        loginForm.Show();
    }

    private void miLogin_Click(object sender, EventArgs e)
    {
        var loginForm = new LoginForm(_controller);
        loginForm.ShowDialog();
    }

    private void miRegister_Click(object sender, EventArgs e)
    {
        var registerForm = new RegisterForm(_controller);
        registerForm.ShowDialog();
    }

    private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_currentTag == null)
        {
            throw new AppException("Chưa chọn thẻ nào để sắp xếp tác vụ.");
        }
        if (cbSort.SelectedIndex == 0)
        {
            SortTodosByDueDate(true);
        }
        else if (cbSort.SelectedIndex == 1)
        {
            SortTodosByContent(true);

        }
    }
    private void SortTodosByDueDate(bool ascending)
    {
        var todos = _todoService.SortByDueDate(_currentTag!.Id, ascending);
        LoadTodos(todos);
    }
    private void SortTodosByContent(bool ascending)
    {
        var todos = _todoService.SortByContent(_currentTag!.Id, ascending);
        LoadTodos(todos);
    }

    private void miShowCalendar_Click(object sender, EventArgs e)
    {
        if (_currentTag == null)
        {
            MessageBox.Show("Vui lòng chọn một thẻ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var calendarForm = new CalendarForm(_controller, _currentTag!);
        calendarForm.ShowDialog();
    }
}
    private void miChangePassword_Click(object sender, EventArgs e)
    {
        if (!_loggedInAccount.IsLoggedIn())
        {
            MessageBox.Show("Cần đăng nhập để đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var form = new todo_app.view.ChangePasswordForm(_controller);
        form.ShowDialog();
    }


    private void btnAddSubTodo_Click(object sender, EventArgs e)
    {
        if (_currentTodo == null)
        {
            return;
        }

        string content = tbAddSubTodo.Text;
        if (string.IsNullOrWhiteSpace(content))
        {
            return;
        }
        DateTime dueDate = dtpCreateTodo.Value;

        _todoService.Create(content, dueDate, _currentTag, false, _currentTodo.Id); ;

        tbAddSubTodo.Clear();
        try
        {
            List<Todo> subTodos = _todoService.FindByParentId(_currentTodo.Id);
            LoadSubTodos(subTodos);
        }
        catch { }
    }

    private void dgvSubTodo_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var selected = dgvSubTodo.Rows[e.RowIndex].DataBoundItem as Todo;
        if (selected == null) return;
    }

    private void dgvSubTodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
        {
            return;
        }

        if (dgvSubTodo.Columns[e.ColumnIndex].Name == "IsDone")
        {
            var selectedSubTodo = dgvSubTodo.Rows[e.RowIndex].DataBoundItem as Todo;
            if (selectedSubTodo == null)
            {
                return;
            }

            _todoService.CheckTodo(selectedSubTodo.Id, !selectedSubTodo.IsDone);
        }
        else if (dgvSubTodo.Columns[e.ColumnIndex].Name == "colDelete")
        {
            var selectedSubTodo = dgvSubTodo.Rows[e.RowIndex].DataBoundItem as Todo;
            if (selectedSubTodo == null)
            {
                return;
            }
            _todoService.Delete(selectedSubTodo.Id);
        }
        else
        {
            return;
        }

        List<Todo> subtodos = _todoService.FindByParentId(_currentTodo!.Id);
        LoadSubTodos(subtodos);
    }

    private void tbAddSubTodo_TextChanged(object sender, EventArgs e)
    {
        if (tbSearchTodo.Text.Length == 0)
        {
            btnSearch.Enabled = false;
        }
        else
        {
            btnSearch.Enabled = true;
        }
    }

}
