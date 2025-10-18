using todo_app.controller;

namespace todo_app;

public partial class LoginForm : Form
{
    private Controller _controller;
    
    public LoginForm(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var registerForm = new RegisterForm(_controller);
        registerForm.Show();
        this.Close();
    }
}