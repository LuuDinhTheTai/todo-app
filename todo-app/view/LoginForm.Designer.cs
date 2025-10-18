using System.ComponentModel;

namespace todo_app;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        gBLogin = new System.Windows.Forms.GroupBox();
        btnRegister = new System.Windows.Forms.Button();
        lblOr = new System.Windows.Forms.Label();
        btnLogin = new System.Windows.Forms.Button();
        tBPassword = new System.Windows.Forms.TextBox();
        lblPassword = new System.Windows.Forms.Label();
        tBUsername = new System.Windows.Forms.TextBox();
        lblUsername = new System.Windows.Forms.Label();
        gBLogin.SuspendLayout();
        SuspendLayout();
        // 
        // gBLogin
        // 
        gBLogin.Controls.Add(btnRegister);
        gBLogin.Controls.Add(lblOr);
        gBLogin.Controls.Add(btnLogin);
        gBLogin.Controls.Add(tBPassword);
        gBLogin.Controls.Add(lblPassword);
        gBLogin.Controls.Add(tBUsername);
        gBLogin.Controls.Add(lblUsername);
        gBLogin.Dock = System.Windows.Forms.DockStyle.Fill;
        gBLogin.Font = new System.Drawing.Font("Segoe UI", 16F);
        gBLogin.Location = new System.Drawing.Point(0, 0);
        gBLogin.Name = "gBLogin";
        gBLogin.Size = new System.Drawing.Size(800, 450);
        gBLogin.TabIndex = 0;
        gBLogin.TabStop = false;
        gBLogin.Text = "Đăng nhập";
        // 
        // btnRegister
        // 
        btnRegister.Location = new System.Drawing.Point(257, 334);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new System.Drawing.Size(263, 44);
        btnRegister.TabIndex = 6;
        btnRegister.Text = "Đăng ký";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // lblOr
        // 
        lblOr.Font = new System.Drawing.Font("Segoe UI", 13F);
        lblOr.Location = new System.Drawing.Point(257, 304);
        lblOr.Name = "lblOr";
        lblOr.Size = new System.Drawing.Size(263, 27);
        lblOr.TabIndex = 5;
        lblOr.Text = "hoặc";
        lblOr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // btnLogin
        // 
        btnLogin.Location = new System.Drawing.Point(257, 257);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(263, 44);
        btnLogin.TabIndex = 4;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = true;
        // 
        // tBPassword
        // 
        tBPassword.Location = new System.Drawing.Point(257, 215);
        tBPassword.Name = "tBPassword";
        tBPassword.Size = new System.Drawing.Size(263, 36);
        tBPassword.TabIndex = 3;
        tBPassword.UseSystemPasswordChar = true;
        // 
        // lblPassword
        // 
        lblPassword.Font = new System.Drawing.Font("Segoe UI", 13F);
        lblPassword.Location = new System.Drawing.Point(257, 185);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new System.Drawing.Size(263, 27);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Mật khẩu";
        // 
        // tBUsername
        // 
        tBUsername.Location = new System.Drawing.Point(257, 146);
        tBUsername.Name = "tBUsername";
        tBUsername.Size = new System.Drawing.Size(263, 36);
        tBUsername.TabIndex = 1;
        // 
        // lblUsername
        // 
        lblUsername.Font = new System.Drawing.Font("Segoe UI", 13F);
        lblUsername.Location = new System.Drawing.Point(257, 116);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new System.Drawing.Size(263, 27);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Tài khoản";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(gBLogin);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        gBLogin.ResumeLayout(false);
        gBLogin.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox tBUsername;
    private System.Windows.Forms.GroupBox gBLogin;
    private System.Windows.Forms.TextBox tBPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Label lblOr;
    private System.Windows.Forms.Button btnRegister;

    #endregion
}