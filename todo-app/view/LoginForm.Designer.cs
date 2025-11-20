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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginForm));
        btnRegister = new Button();
        lblOr = new Label();
        btnLogin = new Button();
        tBPassword = new TextBox();
        lblPassword = new Label();
        tBUsername = new TextBox();
        lblUsername = new Label();
        panel1 = new Panel();
        panel3 = new Panel();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        pictureBox1 = new PictureBox();
        panel2 = new Panel();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        cbRememberMe = new CheckBox();
        panel1.SuspendLayout();
        panel3.SuspendLayout();
        ((ISupportInitialize)pictureBox1).BeginInit();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // btnRegister
        // 
        btnRegister.FlatStyle = FlatStyle.Flat;
        btnRegister.Font = new Font("Segoe UI", 13F);
        btnRegister.Location = new Point(12, 308);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(263, 44);
        btnRegister.TabIndex = 6;
        btnRegister.Text = "Đăng ký";
        btnRegister.UseVisualStyleBackColor = true;
        btnRegister.Click += btnRegister_Click;
        // 
        // lblOr
        // 
        lblOr.Font = new Font("Segoe UI", 11F);
        lblOr.Location = new Point(12, 278);
        lblOr.Name = "lblOr";
        lblOr.Size = new Size(263, 27);
        lblOr.TabIndex = 5;
        lblOr.Text = "hoặc";
        lblOr.TextAlign = ContentAlignment.TopCenter;
        // 
        // btnLogin
        // 
        btnLogin.BackColor = SystemColors.MenuHighlight;
        btnLogin.FlatStyle = FlatStyle.Flat;
        btnLogin.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        btnLogin.ForeColor = SystemColors.Window;
        btnLogin.Location = new Point(12, 231);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(263, 44);
        btnLogin.TabIndex = 4;
        btnLogin.Text = "Đăng nhập";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // tBPassword
        // 
        tBPassword.Font = new Font("Segoe UI", 13F);
        tBPassword.Location = new Point(12, 194);
        tBPassword.Name = "tBPassword";
        tBPassword.Size = new Size(263, 31);
        tBPassword.TabIndex = 3;
        tBPassword.UseSystemPasswordChar = true;
        // 
        // lblPassword
        // 
        lblPassword.Font = new Font("Segoe UI", 13F);
        lblPassword.Location = new Point(12, 164);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(263, 27);
        lblPassword.TabIndex = 2;
        lblPassword.Text = "Mật khẩu";
        // 
        // tBUsername
        // 
        tBUsername.Font = new Font("Segoe UI", 13F);
        tBUsername.ForeColor = SystemColors.WindowText;
        tBUsername.Location = new Point(12, 130);
        tBUsername.Name = "tBUsername";
        tBUsername.Size = new Size(263, 31);
        tBUsername.TabIndex = 1;
        // 
        // lblUsername
        // 
        lblUsername.Font = new Font("Segoe UI", 13F);
        lblUsername.Location = new Point(12, 100);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(263, 27);
        lblUsername.TabIndex = 0;
        lblUsername.Text = "Tài khoản";
        // 
        // panel1
        // 
        panel1.Controls.Add(panel3);
        panel1.Controls.Add(panel2);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(800, 450);
        panel1.TabIndex = 1;
        // 
        // panel3
        // 
        panel3.BackColor = SystemColors.Window;
        panel3.Controls.Add(label4);
        panel3.Controls.Add(label3);
        panel3.Controls.Add(label2);
        panel3.Controls.Add(pictureBox1);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(287, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(513, 450);
        panel3.TabIndex = 9;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 13F);
        label4.ForeColor = SystemColors.MenuHighlight;
        label4.Location = new Point(212, 254);
        label4.Name = "label4";
        label4.Size = new Size(83, 25);
        label4.TabIndex = 3;
        label4.Text = "Hiệu quả";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 13F);
        label3.ForeColor = SystemColors.MenuHighlight;
        label3.Location = new Point(212, 225);
        label3.Name = "label3";
        label3.Size = new Size(68, 25);
        label3.TabIndex = 2;
        label3.Text = "Tiện lợi";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        label2.Location = new Point(212, 184);
        label2.Name = "label2";
        label2.Size = new Size(213, 41);
        label2.TabIndex = 1;
        label2.Text = "Task Manager";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(6, 130);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(200, 200);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        //
        // cbRememberMe
        //
        cbRememberMe.AutoSize = true;
        cbRememberMe.Font = new Font("Segoe UI", 10F);
        cbRememberMe.Location = new Point(12, 360);
        cbRememberMe.Name = "cbRememberMe";
        cbRememberMe.Size = new Size(150, 23);
        cbRememberMe.TabIndex = 7;
        cbRememberMe.Text = "Ghi nhớ đăng nhập";
        cbRememberMe.UseVisualStyleBackColor = true;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnLogin);
        panel2.Controls.Add(label1);
        panel2.Controls.Add(lblPassword);
        panel2.Controls.Add(btnRegister);
        panel2.Controls.Add(cbRememberMe);
        panel2.Controls.Add(tBPassword);
        panel2.Controls.Add(lblOr);
        panel2.Controls.Add(tBUsername);
        panel2.Controls.Add(lblUsername);
        panel2.Dock = DockStyle.Left;
        panel2.Location = new Point(0, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(287, 450);
        panel2.TabIndex = 8;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label1.Location = new Point(12, 70);
        label1.Name = "label1";
        label1.Size = new Size(126, 30);
        label1.TabIndex = 7;
        label1.Text = "Đăng nhập";
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Đăng nhập";
        panel1.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((ISupportInitialize)pictureBox1).EndInit();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.TextBox tBUsername;
    private System.Windows.Forms.TextBox tBPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.Label lblOr;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.CheckBox cbRememberMe;

    #endregion

    private Panel panel1;
    private Label label1;
    private Panel panel2;
    private Panel panel3;
    private PictureBox pictureBox1;
    private Label label2;
    private Label label4;
    private Label label3;
}
