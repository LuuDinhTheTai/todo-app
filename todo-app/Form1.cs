using todo_app.controller;
using todo_app.entity;
using todo_app.service;

namespace todo_app;

public partial class Form1 : Form
{
    private TodoService _todoService;

    private Tag _currentTag;
    private List<Todo> _currentTodos;
    
    public Form1(Controller controller)
    {
        InitializeComponent();
        _todoService = controller.TodoService;

        ConfigDataGridView1();
    }

    private void ConfigDataGridView1()
    {
        dataGridView1.AutoGenerateColumns = false;
        if (dataGridView1.Columns["colStatus"] != null)
        {
            dataGridView1.Columns["colStatus"].DataPropertyName = "IsDone";
        }        
        
        if (dataGridView1.Columns["colContent"] != null)
        {
            dataGridView1.Columns["colContent"].DataPropertyName = "Content";
        }
        
        if (dataGridView1.Columns["colDelete"] != null)
        {
        
        }
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
        dataGridView1.DataSource = todos.OrderBy(t => t.IsDone).ToList();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        var column = dataGridView1.Columns[e.ColumnIndex];

        if (column is DataGridViewButtonColumn && column.Name == "colDelete")
        {
            var todo = dataGridView1.Rows[e.RowIndex].DataBoundItem as Todo;
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
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dataGridView1_CellValueChanged(sender, e);
        }
    }

    private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0)
            return;

        if (dataGridView1.Columns[e.ColumnIndex].Name == "colStatus")
        {
            var todo = dataGridView1.Rows[e.RowIndex].DataBoundItem as Todo;
            if (todo == null)
                return;

            _todoService.Update(todo);

            LoadTodos();
        }
    }
}