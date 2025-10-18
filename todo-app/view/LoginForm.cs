﻿using todo_app.controller;

namespace todo_app;

public partial class LoginForm : Form
{
    private Controller _controller;
    
    private Form1 _form1;
    
    public LoginForm(Controller controller)
    {
        InitializeComponent();
        _controller = controller;
        _form1 = _controller.Form1;
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

        this.Close();
        _form1.Show();
    }
}