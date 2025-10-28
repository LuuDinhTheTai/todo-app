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
        tagDataGridView = new System.Windows.Forms.DataGridView();
        colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
        groupBox1 = new System.Windows.Forms.GroupBox();
        btnExportFileExcel = new System.Windows.Forms.Button();
        btnCreateTag = new System.Windows.Forms.Button();
        tBTagName = new System.Windows.Forms.TextBox();
        lblUsername = new System.Windows.Forms.Label();
        todoDataGridView = new System.Windows.Forms.DataGridView();
        colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
        gBCreateForm = new System.Windows.Forms.GroupBox();
        btnCreate = new System.Windows.Forms.Button();
        tBContent = new System.Windows.Forms.TextBox();
        lblContent = new System.Windows.Forms.Label();
        lblTagName = new System.Windows.Forms.Label();
        sfdExcel = new System.Windows.Forms.SaveFileDialog();
        colDeleteTag = new System.Windows.Forms.DataGridViewButtonColumn();
        btnLogout = new System.Windows.Forms.Button();
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
        splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        splitContainer1.Name = "splitContainer1";
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(tagDataGridView);
        splitContainer1.Panel1.Controls.Add(groupBox1);
        splitContainer1.Panel1.Controls.Add(lblUsername);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(todoDataGridView);
        splitContainer1.Panel2.Controls.Add(gBCreateForm);
        splitContainer1.Panel2.Controls.Add(lblTagName);
        splitContainer1.Size = new System.Drawing.Size(914, 600);
        splitContainer1.SplitterDistance = 303;
        splitContainer1.SplitterWidth = 5;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // tagDataGridView
        // 
        tagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        tagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTag, colDeleteTag });
        tagDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
        tagDataGridView.Location = new System.Drawing.Point(0, 31);
        tagDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        tagDataGridView.Name = "tagDataGridView";
        tagDataGridView.RowHeadersWidth = 51;
        tagDataGridView.Size = new System.Drawing.Size(303, 405);
        tagDataGridView.TabIndex = 4;
        tagDataGridView.Text = "dataGridView2";
        tagDataGridView.CellClick += tagDataGridView_CellClick;
        // 
        // colTag
        // 
        colTag.HeaderText = "Danh sách";
        colTag.MinimumWidth = 6;
        colTag.Name = "colTag";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnLogout);
        groupBox1.Controls.Add(btnExportFileExcel);
        groupBox1.Controls.Add(btnCreateTag);
        groupBox1.Controls.Add(tBTagName);
        groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
        groupBox1.Location = new System.Drawing.Point(0, 467);
        groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
        groupBox1.Size = new System.Drawing.Size(303, 133);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "Thêm danh sách mới";
        // 
        // btnExportFileExcel
        // 
        btnExportFileExcel.Dock = System.Windows.Forms.DockStyle.Top;
        btnExportFileExcel.Location = new System.Drawing.Point(3, 74);
        btnExportFileExcel.Name = "btnExportFileExcel";
        btnExportFileExcel.Size = new System.Drawing.Size(297, 29);
        btnExportFileExcel.TabIndex = 2;
        btnExportFileExcel.Text = "Xuất file excel";
        btnExportFileExcel.UseVisualStyleBackColor = true;
        btnExportFileExcel.Click += btnExportFileExcel_Click;
        // 
        // btnCreateTag
        // 
        btnCreateTag.Dock = System.Windows.Forms.DockStyle.Top;
        btnCreateTag.Location = new System.Drawing.Point(3, 43);
        btnCreateTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnCreateTag.Name = "btnCreateTag";
        btnCreateTag.Size = new System.Drawing.Size(297, 31);
        btnCreateTag.TabIndex = 1;
        btnCreateTag.Text = "Thêm";
        btnCreateTag.UseVisualStyleBackColor = true;
        btnCreateTag.Click += btnCreateTag_Click;
        // 
        // tBTagName
        // 
        tBTagName.Dock = System.Windows.Forms.DockStyle.Top;
        tBTagName.Location = new System.Drawing.Point(3, 20);
        tBTagName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        tBTagName.Name = "tBTagName";
        tBTagName.Size = new System.Drawing.Size(297, 23);
        tBTagName.TabIndex = 0;
        // 
        // lblUsername
        // 
        lblUsername.Dock = System.Windows.Forms.DockStyle.Top;
        lblUsername.Location = new System.Drawing.Point(0, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new System.Drawing.Size(303, 31);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Hi, ";
        lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // todoDataGridView
        // 
        todoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        todoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        colPriority = new System.Windows.Forms.DataGridViewComboBoxColumn();
        colPriority.HeaderText = "Ưu tiên";
        colPriority.MinimumWidth = 6;
        colPriority.Name = "colPriority";
        colPriority.Items.AddRange(new object[] {
            "1 - Thấp",
            "2 - Trung bình",
            "3 - Cao"
        });
        colPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        todoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStatus, colContent, colPriority, colDelete });
        todoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        todoDataGridView.Location = new System.Drawing.Point(0, 31);
        todoDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        todoDataGridView.Name = "todoDataGridView";
        todoDataGridView.RowHeadersWidth = 51;
        todoDataGridView.Size = new System.Drawing.Size(606, 436);
        todoDataGridView.TabIndex = 2;
        todoDataGridView.Text = "dataGridView1";
        todoDataGridView.CellContentClick += todoDataGridView_CellContentClick;
        // 
        // colStatus
        // 
        colStatus.HeaderText = "Trạng thái";
        colStatus.MinimumWidth = 6;
        colStatus.Name = "colStatus";
        // 
        // colContent
        // 
        colContent.HeaderText = "Nội dung";
        colContent.MinimumWidth = 6;
        colContent.Name = "colContent";
        // 
        // colDelete
        // 
        colDelete.HeaderText = "Xóa";
        colDelete.MinimumWidth = 6;
        colDelete.Name = "colDelete";
        // 
        // gBCreateForm
        // 
        gBCreateForm.Controls.Add(btnCreate);
        gBCreateForm.Controls.Add(tBContent);
        gBCreateForm.Controls.Add(lblContent);
        gBCreateForm.Dock = System.Windows.Forms.DockStyle.Bottom;
        gBCreateForm.Location = new System.Drawing.Point(0, 467);
        gBCreateForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        gBCreateForm.Name = "gBCreateForm";
        gBCreateForm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
        gBCreateForm.Size = new System.Drawing.Size(606, 133);
        gBCreateForm.TabIndex = 1;
        gBCreateForm.TabStop = false;
        gBCreateForm.Text = "Thêm tác vụ mới";
        // 
        // btnCreate
        // 
        btnCreate.Dock = System.Windows.Forms.DockStyle.Top;
        btnCreate.Location = new System.Drawing.Point(3, 72);
        btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        btnCreate.Name = "btnCreate";
        btnCreate.Size = new System.Drawing.Size(600, 43);
        btnCreate.TabIndex = 2;
        btnCreate.Text = "Thêm";
        btnCreate.UseVisualStyleBackColor = true;
        btnCreate.Click += btnCreateTodo_Click;
        // 
        // tBContent
        // 
        tBContent.Dock = System.Windows.Forms.DockStyle.Top;
        tBContent.Location = new System.Drawing.Point(3, 43);
        tBContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        tBContent.Multiline = true;
        tBContent.Name = "tBContent";
        tBContent.Size = new System.Drawing.Size(600, 29);
        tBContent.TabIndex = 1;
        // 
        // lblContent
        // 
        lblContent.Dock = System.Windows.Forms.DockStyle.Top;
        lblContent.Location = new System.Drawing.Point(3, 20);
        lblContent.Name = "lblContent";
        lblContent.Size = new System.Drawing.Size(600, 23);
        lblContent.TabIndex = 0;
        lblContent.Text = "Nội dung";
        // 
        // lblTagName
        // 
        lblTagName.Dock = System.Windows.Forms.DockStyle.Top;
        lblTagName.Location = new System.Drawing.Point(0, 0);
        lblTagName.Name = "lblTagName";
        lblTagName.Size = new System.Drawing.Size(606, 31);
        lblTagName.TabIndex = 0;
        lblTagName.Text = "Tác vụ";
        lblTagName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // colDeleteTag
        // 
        colDeleteTag.HeaderText = "Xóa";
        colDeleteTag.Name = "colDeleteTag";
        // 
        // btnLogout
        // 
        btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
        btnLogout.Location = new System.Drawing.Point(3, 106);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new System.Drawing.Size(297, 23);
        btnLogout.TabIndex = 3;
        btnLogout.Text = "Đăng xuất";
        btnLogout.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(914, 600);
        Controls.Add(splitContainer1);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

    private System.Windows.Forms.DataGridViewButtonColumn colDeleteTag;
    private System.Windows.Forms.Button btnLogout;

    private System.Windows.Forms.DataGridViewTextBoxColumn colTag;

    private System.Windows.Forms.DataGridView tagDataGridView;

    private System.Windows.Forms.Button btnCreateTag;

    private System.Windows.Forms.TextBox tBTagName;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
    private System.Windows.Forms.DataGridViewComboBoxColumn colPriority;
    private System.Windows.Forms.DataGridViewButtonColumn colDelete;

    private System.Windows.Forms.DataGridView todoDataGridView;

    private System.Windows.Forms.Button btnCreate;

    private System.Windows.Forms.Label lblContent;
    private System.Windows.Forms.TextBox tBContent;

    private System.Windows.Forms.GroupBox gBCreateForm;

    private System.Windows.Forms.Label lblTagName;

    private System.Windows.Forms.Label lblUsername;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion

    private System.Windows.Forms.Button btnExportFileExcel;
    private SaveFileDialog sfdExcel;
}