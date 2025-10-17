using todo_app.controller;
using todo_app.service;

namespace todo_app;

public partial class Form1 : Form
{
    private TodoService _todoService;
    
    public Form1(Controller controller)
    {
        InitializeComponent();
        _todoService = controller.TodoService;
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
        string content = tBContent.Text;
        _todoService.Create(content);
    }
}