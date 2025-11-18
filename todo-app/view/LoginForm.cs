using todo_app.controller;

namespace todo_app;

public partial class LoginForm : Form
{
    private Controller _controller;

    private MainForm _mainForm;

    public LoginForm(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
        _mainForm = _controller.MainForm;
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var registerForm = new RegisterForm(_controller);
        registerForm.ShowDialog();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        string username = tBUsername.Text;
        string password = tBPassword.Text;
        _controller.AccountService.Login(username, password);

        if (cbRememberMe.Checked)
        {
            _controller.RememberMeService.Save(username, password);
        }
        else
        {
            _controller.RememberMeService.Clear();
        }

        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK);

        Close();

        _mainForm.Reload();
        _mainForm.Show();
    }
}
