using todo_app.controller;
using todo_app.entity;
using todo_app.service;

namespace todo_app;

public partial class Form1 : Form
{
    private TodoService _todoService;
    
    public Form1(Controller controller)
    {
        InitializeComponent();
        _todoService = controller.TodoService;

        dataGridView1.AutoGenerateColumns = false;
        if (dataGridView1.Columns["colStatus"] != null)
            dataGridView1.Columns["colStatus"].DataPropertyName = "IsDone";
        if (dataGridView1.Columns["colContent"] != null)
            dataGridView1.Columns["colContent"].DataPropertyName = "Content";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        LoadTodos();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        string content = tBContent.Text;
        _todoService.Create(content);
        tBContent.Clear();
        LoadTodos();
    }

    private void LoadTodos()
    {
        var todos = _todoService.FindAll();
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = todos.ToList();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0 || e.ColumnIndex < 0)
            return;

        var column = dataGridView1.Columns[e.ColumnIndex];
        if (column == null || column.Name != "colDelete")
            return;

        var row = dataGridView1.Rows[e.RowIndex];
        var todo = row.DataBoundItem as Todo;
        if (todo == null)
            return;

        var result = MessageBox.Show("Xóa tác vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result != DialogResult.Yes)
            return;

        _todoService.Delete(todo.Id);
        LoadTodos();
    }
}