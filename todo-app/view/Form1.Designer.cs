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
        splitContainer1 = new SplitContainer();
        tagDataGridView = new DataGridView();
        colTag = new DataGridViewTextBoxColumn();
        groupBox1 = new GroupBox();
        btnExportFileExcel = new Button();
        btnCreateTag = new Button();
        tBTagName = new TextBox();
        Logout = new Label();
        lblUsername = new Label();
        todoDataGridView = new DataGridView();
        colStatus = new DataGridViewCheckBoxColumn();
        colContent = new DataGridViewTextBoxColumn();
        colDelete = new DataGridViewButtonColumn();
        gBCreateForm = new GroupBox();
        btnCreate = new Button();
        tBContent = new TextBox();
        lblContent = new Label();
        lblTagName = new Label();
        sfdExcel = new SaveFileDialog();
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
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 0);
        splitContainer1.Margin = new Padding(3, 4, 3, 4);
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
        splitContainer1.Size = new Size(914, 600);
        splitContainer1.SplitterDistance = 303;
        splitContainer1.SplitterWidth = 5;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // tagDataGridView
        // 
        tagDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tagDataGridView.Columns.AddRange(new DataGridViewColumn[] { colTag });
        tagDataGridView.Dock = DockStyle.Fill;
        tagDataGridView.Location = new Point(0, 31);
        tagDataGridView.Margin = new Padding(3, 4, 3, 4);
        tagDataGridView.Name = "tagDataGridView";
        tagDataGridView.RowHeadersWidth = 51;
        tagDataGridView.Size = new Size(303, 405);
        tagDataGridView.TabIndex = 4;
        tagDataGridView.Text = "dataGridView2";
        tagDataGridView.CellClick += tagDataGridView_CellClick;
        // 
        // colTag
        // 
        colTag.HeaderText = "Danh sách";
        colTag.MinimumWidth = 6;
        colTag.Name = "colTag";
        colTag.Width = 125;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnExportFileExcel);
        groupBox1.Controls.Add(btnCreateTag);
        groupBox1.Controls.Add(tBTagName);
        groupBox1.Dock = DockStyle.Bottom;
        groupBox1.Location = new Point(0, 436);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(303, 133);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "Thêm danh sách mới";
        // 
        // btnExportFileExcel
        // 
        btnExportFileExcel.Dock = DockStyle.Top;
        btnExportFileExcel.Location = new Point(3, 82);
        btnExportFileExcel.Name = "btnExportFileExcel";
        btnExportFileExcel.Size = new Size(297, 29);
        btnExportFileExcel.TabIndex = 2;
        btnExportFileExcel.Text = "Xuất file excel";
        btnExportFileExcel.UseVisualStyleBackColor = true;
        btnExportFileExcel.Click += btnExportFileExcel_Click;
        // 
        // btnCreateTag
        // 
        btnCreateTag.Dock = DockStyle.Top;
        btnCreateTag.Location = new Point(3, 51);
        btnCreateTag.Margin = new Padding(3, 4, 3, 4);
        btnCreateTag.Name = "btnCreateTag";
        btnCreateTag.Size = new Size(297, 31);
        btnCreateTag.TabIndex = 1;
        btnCreateTag.Text = "Thêm";
        btnCreateTag.UseVisualStyleBackColor = true;
        btnCreateTag.Click += btnCreateTag_Click;
        // 
        // tBTagName
        // 
        tBTagName.Dock = DockStyle.Top;
        tBTagName.Location = new Point(3, 24);
        tBTagName.Margin = new Padding(3, 4, 3, 4);
        tBTagName.Name = "tBTagName";
        tBTagName.Size = new Size(297, 27);
        tBTagName.TabIndex = 0;
        // 
        // Logout
        // 
        Logout.Dock = DockStyle.Bottom;
        Logout.Location = new Point(0, 569);
        Logout.Name = "Logout";
        Logout.Size = new Size(303, 31);
        Logout.TabIndex = 2;
        Logout.Text = "Logout";
        Logout.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblUsername
        // 
        lblUsername.Dock = DockStyle.Top;
        lblUsername.Location = new Point(0, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(303, 31);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Hi, ";
        lblUsername.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // todoDataGridView
        // 
        todoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        todoDataGridView.Columns.AddRange(new DataGridViewColumn[] { colStatus, colContent, colDelete });
        todoDataGridView.Dock = DockStyle.Fill;
        todoDataGridView.Location = new Point(0, 31);
        todoDataGridView.Margin = new Padding(3, 4, 3, 4);
        todoDataGridView.Name = "todoDataGridView";
        todoDataGridView.RowHeadersWidth = 51;
        todoDataGridView.Size = new Size(606, 436);
        todoDataGridView.TabIndex = 2;
        todoDataGridView.Text = "dataGridView1";
        todoDataGridView.CellContentClick += todoDataGridView_CellContentClick;
        // 
        // colStatus
        // 
        colStatus.HeaderText = "Trạng thái";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        colStatus.Width = 125;
        // 
        // colContent
        // 
        colContent.HeaderText = "Nội dung";
        colContent.MinimumWidth = 6;
        colContent.Name = "colContent";
        colContent.Width = 125;
        // 
        // colDelete
        // 
        colDelete.HeaderText = "Xóa";
        colDelete.MinimumWidth = 6;
        colDelete.Name = "colDelete";
        colDelete.Width = 125;
        // 
        // gBCreateForm
        // 
        gBCreateForm.Controls.Add(btnCreate);
        gBCreateForm.Controls.Add(tBContent);
        gBCreateForm.Controls.Add(lblContent);
        gBCreateForm.Dock = DockStyle.Bottom;
        gBCreateForm.Location = new Point(0, 467);
        gBCreateForm.Margin = new Padding(3, 4, 3, 4);
        gBCreateForm.Name = "gBCreateForm";
        gBCreateForm.Padding = new Padding(3, 4, 3, 4);
        gBCreateForm.Size = new Size(606, 133);
        gBCreateForm.TabIndex = 1;
        gBCreateForm.TabStop = false;
        gBCreateForm.Text = "Thêm tác vụ mới";
        // 
        // btnCreate
        // 
        btnCreate.Location = new Point(79, 60);
        btnCreate.Margin = new Padding(3, 4, 3, 4);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new Size(127, 43);
        btnCreate.TabIndex = 2;
        btnCreate.Text = "Thêm";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreateTodo_Click;
        // 
        // tBContent
        // 
        tBContent.Location = new Point(79, 21);
        tBContent.Margin = new Padding(3, 4, 3, 4);
        tBContent.Multiline = true;
        tBContent.Name = "tBContent";
        tBContent.Size = new Size(513, 29);
        tBContent.TabIndex = 1;
        // 
        // lblContent
        // 
        lblContent.Location = new Point(7, 25);
        lblContent.Name = "lblContent";
        lblContent.Size = new Size(114, 31);
        lblContent.TabIndex = 0;
        lblContent.Text = "Nội dung";
        // 
        // lblTagName
        // 
        lblTagName.Dock = DockStyle.Top;
        lblTagName.Location = new Point(0, 0);
        lblTagName.Name = "lblTagName";
        lblTagName.Size = new Size(606, 31);
        lblTagName.TabIndex = 0;
        lblTagName.Text = "Tác vụ";
        lblTagName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(splitContainer1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
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

    private Button btnExportFileExcel;
    private SaveFileDialog sfdExcel;
}