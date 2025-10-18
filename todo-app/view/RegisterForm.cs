using todo_app.controller;
using todo_app.service;

namespace todo_app;

public partial class RegisterForm : Form
{
    private Controller _controller;
    private AccountService _accountService;
    
    public RegisterForm(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
        _accountService = controller.AccountService;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        string username = tBUsername.Text;
        string password = tbPassword.Text;
        string confirmPassword = tBCofirmPassword.Text;
        _accountService.Register(username, password, confirmPassword);

        var loginForm = new LoginForm(_controller);
        loginForm.Show();
        this.Close();
    }
}