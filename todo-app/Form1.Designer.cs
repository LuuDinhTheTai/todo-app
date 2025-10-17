namespace todo_app;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        lBSidebar = new System.Windows.Forms.ListBox();
        Logout = new System.Windows.Forms.Label();
        lblUsername = new System.Windows.Forms.Label();
        gBCreateForm = new System.Windows.Forms.GroupBox();
        btnCreate = new System.Windows.Forms.Button();
        tBContent = new System.Windows.Forms.TextBox();
        lblContent = new System.Windows.Forms.Label();
        lblTagName = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        gBCreateForm.SuspendLayout();
        SuspendLayout();
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        splitContainer1.Location = new System.Drawing.Point(0, 0);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(lBSidebar);
        splitContainer1.Panel1.Controls.Add(Logout);
        splitContainer1.Panel1.Controls.Add(lblUsername);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(gBCreateForm);
        splitContainer1.Panel2.Controls.Add(lblTagName);
        splitContainer1.Size = new System.Drawing.Size(800, 450);
        splitContainer1.SplitterDistance = 266;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // lBSidebar
        // 
        lBSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
        lBSidebar.FormattingEnabled = true;
        lBSidebar.Items.AddRange(new object[] { "Tác vụ" });
        lBSidebar.Location = new System.Drawing.Point(0, 23);
        lBSidebar.Name = "lBSidebar";
        lBSidebar.Size = new System.Drawing.Size(266, 404);
        lBSidebar.TabIndex = 3;
        // 
        // Logout
        // 
        Logout.Dock = System.Windows.Forms.DockStyle.Bottom;
        Logout.Location = new System.Drawing.Point(0, 427);
        Logout.Name = "Logout";
        Logout.Size = new System.Drawing.Size(266, 23);
        Logout.TabIndex = 2;
        Logout.Text = "Logout";
        Logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lblUsername
        // 
        lblUsername.Dock = System.Windows.Forms.DockStyle.Top;
        lblUsername.Location = new System.Drawing.Point(0, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new System.Drawing.Size(266, 23);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Hi, ";
        lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // gBCreateForm
        // 
        gBCreateForm.Controls.Add(btnCreate);
        gBCreateForm.Controls.Add(tBContent);
        gBCreateForm.Controls.Add(lblContent);
        gBCreateForm.Dock = System.Windows.Forms.DockStyle.Bottom;
        gBCreateForm.Location = new System.Drawing.Point(0, 350);
        gBCreateForm.Name = "gBCreateForm";
        gBCreateForm.Size = new System.Drawing.Size(530, 100);
        gBCreateForm.TabIndex = 1;
        gBCreateForm.TabStop = false;
        gBCreateForm.Text = "Thêm tác vụ mới";
        // 
        // btnCreate
        // 
        btnCreate.Location = new System.Drawing.Point(69, 45);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new System.Drawing.Size(111, 32);
        btnCreate.TabIndex = 2;
        btnCreate.Text = "Thêm";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreate_Click;
        // 
        // tBContent
        // 
        tBContent.Location = new System.Drawing.Point(69, 16);
        tBContent.Multiline = true;
        tBContent.Name = "tBContent";
        tBContent.Size = new System.Drawing.Size(449, 23);
        tBContent.TabIndex = 1;
        // 
        // lblContent
        // 
        lblContent.Location = new System.Drawing.Point(6, 19);
        lblContent.Name = "lblContent";
        lblContent.Size = new System.Drawing.Size(100, 23);
        lblContent.TabIndex = 0;
        lblContent.Text = "Nội dung";
        // 
        // lblTagName
        // 
        lblTagName.Dock = System.Windows.Forms.DockStyle.Top;
        lblTagName.Location = new System.Drawing.Point(0, 0);
        lblTagName.Name = "lblTagName";
        lblTagName.Size = new System.Drawing.Size(530, 23);
        lblTagName.TabIndex = 0;
        lblTagName.Text = "Tác vụ";
        lblTagName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(splitContainer1);
        Text = "Form1";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        gBCreateForm.ResumeLayout(false);
        gBCreateForm.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnCreate;

    private System.Windows.Forms.Label lblContent;
    private System.Windows.Forms.TextBox tBContent;

    private System.Windows.Forms.GroupBox gBCreateForm;

    private System.Windows.Forms.Label lblTagName;

    private System.Windows.Forms.Label Logout;

    private System.Windows.Forms.Label lblUsername;

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ListBox lBSidebar;

    #endregion
}