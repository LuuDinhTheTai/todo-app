namespace todo_app;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;

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
        tagDataGridView = new System.Windows.Forms.DataGridView();
        colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
        groupBox1 = new System.Windows.Forms.GroupBox();
        btnCreateTag = new System.Windows.Forms.Button();
        tBTagName = new System.Windows.Forms.TextBox();
        Logout = new System.Windows.Forms.Label();
        lblUsername = new System.Windows.Forms.Label();
        todoDataGridView = new System.Windows.Forms.DataGridView();
        colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
        colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        gBCreateForm = new System.Windows.Forms.GroupBox();
        btnCreate = new System.Windows.Forms.Button();
        tBContent = new System.Windows.Forms.TextBox();
        lblContent = new System.Windows.Forms.Label();
        lblTagName = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tagDataGridView).BeginInit();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)todoDataGridView).BeginInit();
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
        splitContainer1.Panel1.Controls.Add(tagDataGridView);
        splitContainer1.Panel1.Controls.Add(groupBox1);
        splitContainer1.Panel1.Controls.Add(Logout);
        splitContainer1.Panel1.Controls.Add(lblUsername);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(todoDataGridView);
        splitContainer1.Panel2.Controls.Add(gBCreateForm);
        splitContainer1.Panel2.Controls.Add(lblTagName);
        splitContainer1.Size = new System.Drawing.Size(800, 450);
        splitContainer1.SplitterDistance = 266;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // tagDataGridView
        // 
        tagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTag });
        tagDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        tagDataGridView.Location = new System.Drawing.Point(0, 23);
        tagDataGridView.Name = "tagDataGridView";
        tagDataGridView.Size = new System.Drawing.Size(266, 304);
        tagDataGridView.TabIndex = 4;
        tagDataGridView.Text = "dataGridView2";
        tagDataGridView.CellClick += tagDataGridView_CellClick;
        // 
        // colTag
        // 
        colTag.HeaderText = "Danh sách";
        colTag.Name = "colTag";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnCreateTag);
        groupBox1.Controls.Add(tBTagName);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
        groupBox1.Location = new System.Drawing.Point(0, 327);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(266, 100);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "Thêm danh sách mới";
        // 
        // btnCreateTag
        // 
        btnCreateTag.Dock = System.Windows.Forms.DockStyle.Top;
        btnCreateTag.Location = new System.Drawing.Point(3, 42);
        btnCreateTag.Name = "btnCreateTag";
        btnCreateTag.Size = new System.Drawing.Size(260, 23);
        btnCreateTag.TabIndex = 1;
        btnCreateTag.Text = "Thêm";
        btnCreateTag.UseVisualStyleBackColor = true;
        btnCreateTag.Click += btnCreateTag_Click;
        // 
        // tBTagName
        // 
        tBTagName.Dock = System.Windows.Forms.DockStyle.Top;
        tBTagName.Location = new System.Drawing.Point(3, 19);
        tBTagName.Name = "tBTagName";
        tBTagName.Size = new System.Drawing.Size(260, 23);
        tBTagName.TabIndex = 0;
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
        // todoDataGridView
        // 
        todoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        todoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStatus, colContent, colDelete, colDueDate });
        todoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        todoDataGridView.Location = new System.Drawing.Point(0, 23);
        todoDataGridView.Name = "todoDataGridView";
        todoDataGridView.Size = new System.Drawing.Size(530, 327);
        todoDataGridView.TabIndex = 2;
        todoDataGridView.Text = "dataGridView1";
        todoDataGridView.CellContentClick += todoDataGridView_CellContentClick;
        todoDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.todoDataGridView_CellFormatting);
        todoDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.todoDataGridView_CellValueChanged);
        // 
        // colStatus
        // 
        colStatus.HeaderText = "Trạng thái";
        colStatus.Name = "colStatus";
        // 
        // colContent
        // 
        colContent.HeaderText = "Nội dung";
        colContent.Name = "colContent";
        // 
        // colDelete
        // 
        colDelete.HeaderText = "Xóa";
        colDelete.Name = "colDelete";
        // 
        // colDueDate
        // 
        colDueDate.HeaderText = "Hạn chót";
        colDueDate.Name = "colDueDate";
        colDueDate.DataPropertyName = "DueDate";
        colDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
        var dueDateCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
        dueDateCellStyle.Format = "g"; // short date + short time
        dueDateCellStyle.NullValue = null;
        colDueDate.DefaultCellStyle = dueDateCellStyle;
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
        btnCreate.Click += btnCreateTodo_Click;
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
        Load += Form1_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tagDataGridView).EndInit();
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)todoDataGridView).EndInit();
        gBCreateForm.ResumeLayout(false);
        gBCreateForm.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridViewTextBoxColumn colTag;

    private System.Windows.Forms.DataGridView tagDataGridView;

    private System.Windows.Forms.Button btnCreateTag;

    private System.Windows.Forms.TextBox tBTagName;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
    private System.Windows.Forms.DataGridViewButtonColumn colDelete;

    private System.Windows.Forms.DataGridView todoDataGridView;

    private System.Windows.Forms.Button btnCreate;

    private System.Windows.Forms.Label lblContent;
    private System.Windows.Forms.TextBox tBContent;

    private System.Windows.Forms.GroupBox gBCreateForm;

    private System.Windows.Forms.Label lblTagName;

    private System.Windows.Forms.Label Logout;

    private System.Windows.Forms.Label lblUsername;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion
}
