using System.ComponentModel;

namespace todo_app;

partial class RegisterForm
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
        gBRegister = new System.Windows.Forms.GroupBox();
        btnLogin = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        btnRegister = new System.Windows.Forms.Button();
        tBCofirmPassword = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        tbPassword = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        tBUsername = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        gBRegister.SuspendLayout();
        SuspendLayout();
        // 
        // gBRegister
        // 
        gBRegister.Controls.Add(btnLogin);
        gBRegister.Controls.Add(label4);
        gBRegister.Controls.Add(btnRegister);
        gBRegister.Controls.Add(tBCofirmPassword);
        gBRegister.Controls.Add(label3);
        gBRegister.Controls.Add(tbPassword);
        gBRegister.Controls.Add(label2);
        gBRegister.Controls.Add(tBUsername);
        gBRegister.Controls.Add(label1);
        gBRegister.Dock = System.Windows.Forms.DockStyle.Fill;
        gBRegister.Font = new System.Drawing.Font("Segoe UI", 16F);
        gBRegister.Location = new System.Drawing.Point(0, 0);
        gBRegister.Name = "gBRegister";
        gBRegister.Size = new System.Drawing.Size(800, 450);
        gBRegister.TabIndex = 0;
        gBRegister.TabStop = false;
        gBRegister.Text = "Đăng ký";
        // 
        // btnLogin
        // 
        btnLogin.Location = new System.Drawing.Point(269, 366);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new System.Drawing.Size(234, 47);
        btnLogin.TabIndex = 8;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 13F);
        label4.Location = new System.Drawing.Point(269, 335);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(234, 28);
        label4.TabIndex = 7;
        label4.Text = "hoặc";
        label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // btnRegister
        // 
        btnRegister.Location = new System.Drawing.Point(269, 285);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new System.Drawing.Size(234, 47);
        btnRegister.TabIndex = 6;
        btnRegister.Text = "Đăng ký";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // tBCofirmPassword
        // 
        tBCofirmPassword.Location = new System.Drawing.Point(269, 243);
        tBCofirmPassword.Name = "tBCofirmPassword";
        tBCofirmPassword.Size = new System.Drawing.Size(234, 36);
        tBCofirmPassword.TabIndex = 5;
        tBCofirmPassword.UseSystemPasswordChar = true;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 13F);
        label3.Location = new System.Drawing.Point(269, 212);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(234, 28);
        label3.TabIndex = 4;
        label3.Text = "Nhập lại mật khẩu";
        // 
        // tbPassword
        // 
        tbPassword.Location = new System.Drawing.Point(269, 173);
        tbPassword.Name = "tbPassword";
        tbPassword.Size = new System.Drawing.Size(234, 36);
        tbPassword.TabIndex = 3;
        tbPassword.UseSystemPasswordChar = true;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 13F);
        label2.Location = new System.Drawing.Point(269, 142);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(234, 28);
        label2.TabIndex = 2;
        label2.Text = "Mật khẩu";
        // 
        // tBUsername
        // 
        tBUsername.Location = new System.Drawing.Point(269, 103);
        tBUsername.Name = "tBUsername";
        tBUsername.Size = new System.Drawing.Size(234, 36);
        tBUsername.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 13F);
        label1.Location = new System.Drawing.Point(269, 72);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(234, 28);
        label1.TabIndex = 0;
        label1.Text = "Tài khoản";
        // 
        // RegisterForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(gBRegister);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Đăng ký";
        gBRegister.ResumeLayout(false);
        gBRegister.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tBUsername;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbPassword;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox tBCofirmPassword;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnLogin;

    private System.Windows.Forms.GroupBox gBRegister;

    #endregion
}