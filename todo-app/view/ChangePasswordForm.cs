using todo_app.controller;
using todo_app.exception;
using todo_app.service;

namespace todo_app.view;

public partial class ChangePasswordForm : Form
{
    private readonly AccountService _accountService;

    public ChangePasswordForm(Controller controller)
    {
        InitializeComponent();
        _accountService = controller.AccountService;
    }

    private void btnChange_Click(object? sender, EventArgs e)
    {
        try
        {
            _accountService.ChangePassword(txtOld.Text, txtNew.Text, txtConfirm.Text);
            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
        catch (AppException ex)
        {
            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
