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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        splitContainer1 = new System.Windows.Forms.SplitContainer();
        tbCreateTag = new System.Windows.Forms.TextBox();
        tagDataGridView = new System.Windows.Forms.DataGridView();
        colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDeleteTag = new System.Windows.Forms.DataGridViewButtonColumn();
        lblUsername = new System.Windows.Forms.Label();
        tbCreateTodo = new System.Windows.Forms.TextBox();
        todoDataGridView = new System.Windows.Forms.DataGridView();
        colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
        colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
        colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
        lbTagName = new System.Windows.Forms.Label();
        sfdExcel = new System.Windows.Forms.SaveFileDialog();
        btnShowChart = new System.Windows.Forms.Button();
        btnExportFileExcel = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)tagDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)todoDataGridView).BeginInit();
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
        splitContainer1.Panel1.Controls.Add(btnExportFileExcel);
        splitContainer1.Panel1.Controls.Add(tbCreateTag);
        splitContainer1.Panel1.Controls.Add(tagDataGridView);
        splitContainer1.Panel1.Controls.Add(lblUsername);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(btnShowChart);
        splitContainer1.Panel2.Controls.Add(tbCreateTodo);
        splitContainer1.Panel2.Controls.Add(todoDataGridView);
        splitContainer1.Panel2.Controls.Add(lbTagName);
        splitContainer1.Size = new System.Drawing.Size(1184, 661);
        splitContainer1.SplitterDistance = 310;
        splitContainer1.SplitterWidth = 5;
        splitContainer1.TabIndex = 0;
        splitContainer1.Text = "splitContainer1";
        // 
        // tbCreateTag
        // 
        tbCreateTag.Dock = System.Windows.Forms.DockStyle.Top;
        tbCreateTag.Location = new System.Drawing.Point(0, 31);
        tbCreateTag.Name = "tbCreateTag";
        tbCreateTag.PlaceholderText = "+ Thêm danh sách";
        tbCreateTag.Size = new System.Drawing.Size(310, 23);
        tbCreateTag.TabIndex = 5;
        tbCreateTag.KeyDown += tbCreateTag_KeyDown;
        // 
        // tagDataGridView
        // 
        tagDataGridView.AllowUserToAddRows = false;
        tagDataGridView.AllowUserToDeleteRows = false;
        tagDataGridView.AllowUserToOrderColumns = true;
        tagDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        tagDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
        tagDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        tagDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tagDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colTag, colDeleteTag });
        tagDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        tagDataGridView.Location = new System.Drawing.Point(0, 31);
        tagDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        tagDataGridView.Name = "tagDataGridView";
        tagDataGridView.RowHeadersWidth = 51;
        tagDataGridView.Size = new System.Drawing.Size(310, 630);
        tagDataGridView.TabIndex = 4;
        tagDataGridView.Text = "dataGridView2";
        tagDataGridView.CellClick += tagDataGridView_CellClick;
        tagDataGridView.CellContentClick += tagDataGridView_CellContentClick;
        // 
        // colTag
        // 
        colTag.HeaderText = "Danh sách";
        colTag.MinimumWidth = 6;
        colTag.Name = "colTag";
        // 
        // colDeleteTag
        // 
        colDeleteTag.HeaderText = "Xóa";
        colDeleteTag.Name = "colDeleteTag";
        // 
        // lblUsername
        // 
        lblUsername.Dock = System.Windows.Forms.DockStyle.Top;
        lblUsername.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lblUsername.Location = new System.Drawing.Point(0, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new System.Drawing.Size(310, 31);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Hi, ";
        lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tbCreateTodo
        // 
        tbCreateTodo.Dock = System.Windows.Forms.DockStyle.Top;
        tbCreateTodo.Location = new System.Drawing.Point(0, 54);
        tbCreateTodo.Name = "tbCreateTodo";
        tbCreateTodo.PlaceholderText = "+ Thêm tác vụ";
        tbCreateTodo.Size = new System.Drawing.Size(869, 23);
        tbCreateTodo.TabIndex = 3;
        tbCreateTodo.KeyDown += tbCreateTodo_KeyDown;
        // 
        // todoDataGridView
        // 
        todoDataGridView.AllowUserToAddRows = false;
        todoDataGridView.AllowUserToDeleteRows = false;
        todoDataGridView.AllowUserToOrderColumns = true;
        todoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        todoDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
        todoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
        todoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        todoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colStatus, colContent, colDueDate, colDelete });
        todoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        todoDataGridView.Location = new System.Drawing.Point(0, 54);
        todoDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        todoDataGridView.Name = "todoDataGridView";
        todoDataGridView.RowHeadersWidth = 51;
        todoDataGridView.Size = new System.Drawing.Size(869, 607);
        todoDataGridView.TabIndex = 2;
        todoDataGridView.Text = "dataGridView1";
        todoDataGridView.CellContentClick += todoDataGridView_CellContentClick;
        todoDataGridView.CellFormatting += todoDataGridView_CellFormatting;
        todoDataGridView.CellValueChanged += todoDataGridView_CellValueChanged;
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
        // colDueDate
        // 
        colDueDate.DataPropertyName = "DueDate";
        dataGridViewCellStyle1.Format = "g";
        dataGridViewCellStyle1.NullValue = null;
        colDueDate.DefaultCellStyle = dataGridViewCellStyle1;
        colDueDate.HeaderText = "Hạn chót";
        colDueDate.MinimumWidth = 6;
        colDueDate.Name = "colDueDate";
        // 
        // colDelete
        // 
        colDelete.HeaderText = "Xóa";
        colDelete.MinimumWidth = 6;
        colDelete.Name = "colDelete";
        // 
        // lbTagName
        // 
        lbTagName.Dock = System.Windows.Forms.DockStyle.Top;
        lbTagName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
        lbTagName.Location = new System.Drawing.Point(0, 0);
        lbTagName.Name = "lbTagName";
        lbTagName.Size = new System.Drawing.Size(869, 54);
        lbTagName.TabIndex = 0;
        lbTagName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
        // 
        // btnShowChart
        // 
        btnShowChart.Dock = System.Windows.Forms.DockStyle.Bottom;
        btnShowChart.Location = new System.Drawing.Point(0, 632);
        btnShowChart.Name = "btnShowChart";
        btnShowChart.Size = new System.Drawing.Size(869, 29);
        btnShowChart.TabIndex = 7;
        btnShowChart.Text = "Vẽ biểu đồ";
        btnShowChart.UseVisualStyleBackColor = true;
        // 
        // btnExportFileExcel
        // 
        btnExportFileExcel.Dock = System.Windows.Forms.DockStyle.Bottom;
        btnExportFileExcel.Location = new System.Drawing.Point(0, 632);
        btnExportFileExcel.Name = "btnExportFileExcel";
        btnExportFileExcel.Size = new System.Drawing.Size(310, 29);
        btnExportFileExcel.TabIndex = 6;
        btnExportFileExcel.Text = "Xuất file excel";
        btnExportFileExcel.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1184, 661);
        Controls.Add(splitContainer1);
        Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form1";
        Load += Form1_Load;
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)tagDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)todoDataGridView).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnShowChart;

    private System.Windows.Forms.TextBox tbCreateTag;

    private System.Windows.Forms.TextBox tbCreateTodo;

    private System.Windows.Forms.DataGridViewButtonColumn colDeleteTag;

    private System.Windows.Forms.DataGridViewTextBoxColumn colTag;

    private System.Windows.Forms.DataGridView tagDataGridView;

    private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
    private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
    private System.Windows.Forms.DataGridViewButtonColumn colDelete;

    private System.Windows.Forms.DataGridView todoDataGridView;

    private System.Windows.Forms.Label lbTagName;

    private System.Windows.Forms.Label lblUsername;

    private System.Windows.Forms.SplitContainer splitContainer1;

    #endregion

    private System.Windows.Forms.Button btnExportFileExcel;
    private System.Windows.Forms.SaveFileDialog sfdExcel;
}
