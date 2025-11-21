namespace todo_app;

partial class MainForm
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        sfdExcel = new SaveFileDialog();
        panelHeader = new Panel();
        btnSearch = new Button();
        btnUserMenu = new Button();
        tbSearchTodo = new TextBox();
        label3 = new Label();
        btnToggleLeftSideBar = new Button();
        panelLeftSideBar = new Panel();
        dgvTags = new DataGridView();
        tbCreateTag = new TextBox();
        panelRightSideBar = new Panel();
        lbCurrentTodoTagName = new Label();
        label1 = new Label();
        cbStatusTodo = new CheckBox();
        panel1 = new Panel();
        btnHideRightSideBar = new Button();
        btnDeleteTodo = new Button();
        tbCurrentTodoNote = new TextBox();
        label2 = new Label();
        dtpCurrentTodoDueDate = new DateTimePicker();
        lbCurrentTodoName = new Label();
        panelMainContent = new Panel();
        panel6 = new Panel();
        dgvTodos = new DataGridView();
        panel2 = new Panel();
        panel5 = new Panel();
        cbSort = new ComboBox();
        lbTagName = new Label();
        btnTagMenu = new Button();
        panel4 = new Panel();
        tbCreateTodo = new TextBox();
        panel3 = new Panel();
        dtpCreateTodo = new DateTimePicker();
        btnCreateTodo = new Button();
        cmsUserMenu = new ContextMenuStrip(components);
        miExportFile = new ToolStripMenuItem();
        miLogin = new ToolStripMenuItem();
        miRegister = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        miLogout = new ToolStripMenuItem();
        miChangePassword = new ToolStripMenuItem();
        cmsTagMenu = new ContextMenuStrip(components);
        miDrawChart = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        miDeleteTag = new ToolStripMenuItem();
        miShowCalendar = new ToolStripMenuItem();
        panelHeader.SuspendLayout();
        panelLeftSideBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
        panelRightSideBar.SuspendLayout();
        panel1.SuspendLayout();
        panelMainContent.SuspendLayout();
        panel6.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTodos).BeginInit();
        panel2.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        panel3.SuspendLayout();
        cmsUserMenu.SuspendLayout();
        cmsTagMenu.SuspendLayout();
        SuspendLayout();
        // 
        // panelHeader
        // 
        panelHeader.BackColor = SystemColors.MenuHighlight;
        panelHeader.Controls.Add(btnSearch);
        panelHeader.Controls.Add(btnUserMenu);
        panelHeader.Controls.Add(tbSearchTodo);
        panelHeader.Controls.Add(label3);
        panelHeader.Controls.Add(btnToggleLeftSideBar);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Location = new Point(0, 0);
        panelHeader.Margin = new Padding(3, 4, 3, 4);
        panelHeader.Name = "panelHeader";
        panelHeader.Size = new Size(1445, 67);
        panelHeader.TabIndex = 0;
        // 
        // btnSearch
        // 
        btnSearch.BackColor = SystemColors.MenuHighlight;
        btnSearch.BackgroundImage = (Image)resources.GetObject("btnSearch.BackgroundImage");
        btnSearch.BackgroundImageLayout = ImageLayout.Stretch;
        btnSearch.FlatAppearance.BorderSize = 0;
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnSearch.Location = new Point(971, 12);
        btnSearch.Margin = new Padding(3, 4, 3, 4);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(80, 39);
        btnSearch.Size = new Size(29, 29);
        btnSearch.TabIndex = 4;
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnUserMenu
        // 
        btnUserMenu.BackgroundImage = (Image)resources.GetObject("btnUserMenu.BackgroundImage");
        btnUserMenu.BackgroundImageLayout = ImageLayout.Stretch;
        btnUserMenu.Dock = DockStyle.Right;
        btnUserMenu.FlatAppearance.BorderSize = 0;
        btnUserMenu.FlatStyle = FlatStyle.Flat;
        btnUserMenu.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        btnUserMenu.ForeColor = SystemColors.Window;
        btnUserMenu.Location = new Point(1388, 0);
        btnUserMenu.Margin = new Padding(3, 4, 3, 4);
        btnUserMenu.Name = "btnUserMenu";
        btnUserMenu.Size = new Size(57, 67);
        btnUserMenu.TabIndex = 3;
        btnUserMenu.UseVisualStyleBackColor = true;
        btnUserMenu.Click += btnUserMenu_Click;
        // 
        // tbSearchTodo
        // 
        tbSearchTodo.Font = new Font("Segoe UI", 12F);
        tbSearchTodo.Location = new Point(416, 12);
        tbSearchTodo.Margin = new Padding(3, 4, 3, 4);
        tbSearchTodo.Name = "tbSearchTodo";
        tbSearchTodo.PlaceholderText = " Tìm kiếm tác vụ";
        tbSearchTodo.Size = new Size(548, 34);
        tbSearchTodo.TabIndex = 2;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = SystemColors.MenuHighlight;
        label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        label3.ForeColor = SystemColors.Window;
        label3.Location = new Point(75, 12);
        label3.Name = "label3";
        label3.Size = new Size(195, 37);
        label3.TabIndex = 1;
        label3.Text = "Task Manager";
        // 
        // btnToggleLeftSideBar
        // 
        btnToggleLeftSideBar.BackgroundImage = (Image)resources.GetObject("btnToggleLeftSideBar.BackgroundImage");
        btnToggleLeftSideBar.BackgroundImageLayout = ImageLayout.Center;
        btnToggleLeftSideBar.Dock = DockStyle.Left;
        btnToggleLeftSideBar.FlatAppearance.BorderSize = 0;
        btnToggleLeftSideBar.FlatStyle = FlatStyle.Flat;
        btnToggleLeftSideBar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        btnToggleLeftSideBar.ForeColor = SystemColors.Window;
        btnToggleLeftSideBar.Location = new Point(0, 0);
        btnToggleLeftSideBar.Margin = new Padding(3, 4, 3, 4);
        btnToggleLeftSideBar.Name = "btnToggleLeftSideBar";
        btnToggleLeftSideBar.Size = new Size(69, 67);
        btnToggleLeftSideBar.TabIndex = 0;
        btnToggleLeftSideBar.UseVisualStyleBackColor = true;
        btnToggleLeftSideBar.Click += btnToggleLeftSideBar_Click;
        // 
        // panelLeftSideBar
        // 
        panelLeftSideBar.BackColor = SystemColors.Window;
        panelLeftSideBar.Controls.Add(dgvTags);
        panelLeftSideBar.Controls.Add(tbCreateTag);
        panelLeftSideBar.Dock = DockStyle.Left;
        panelLeftSideBar.Location = new Point(0, 67);
        panelLeftSideBar.Margin = new Padding(3, 4, 3, 4);
        panelLeftSideBar.Name = "panelLeftSideBar";
        panelLeftSideBar.Size = new Size(286, 894);
        panelLeftSideBar.TabIndex = 1;
        // 
        // dgvTags
        // 
        dgvTags.AllowUserToAddRows = false;
        dgvTags.AllowUserToDeleteRows = false;
        dgvTags.AllowUserToOrderColumns = true;
        dgvTags.AllowUserToResizeColumns = false;
        dgvTags.AllowUserToResizeRows = false;
        dgvTags.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTags.BackgroundColor = SystemColors.Window;
        dgvTags.BorderStyle = BorderStyle.None;
        dgvTags.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTags.ColumnHeadersVisible = false;
        dgvTags.Dock = DockStyle.Fill;
        dgvTags.Location = new Point(0, 32);
        dgvTags.Margin = new Padding(3, 4, 3, 4);
        dgvTags.Name = "dgvTags";
        dgvTags.ReadOnly = true;
        dgvTags.RowHeadersVisible = false;
        dgvTags.RowHeadersWidth = 51;
        dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dgvTags.RowsDefaultCellStyle = dataGridViewCellStyle1;
        dgvTags.Size = new Size(286, 862);
        dgvTags.TabIndex = 1;
        dgvTags.CellClick += dgvTags_CellClick;
        // 
        // tbCreateTag
        // 
        tbCreateTag.Dock = DockStyle.Top;
        tbCreateTag.Font = new Font("Segoe UI", 11F);
        tbCreateTag.Location = new Point(0, 0);
        tbCreateTag.Margin = new Padding(3, 4, 3, 4);
        tbCreateTag.Name = "tbCreateTag";
        tbCreateTag.PlaceholderText = " + Danh sách mới";
        tbCreateTag.Size = new Size(286, 32);
        tbCreateTag.TabIndex = 0;
        tbCreateTag.KeyDown += tbCreateTag_KeyDown;
        // 
        // panelRightSideBar
        // 
        panelRightSideBar.BackColor = SystemColors.Window;
        panelRightSideBar.Controls.Add(lbCurrentTodoTagName);
        panelRightSideBar.Controls.Add(label1);
        panelRightSideBar.Controls.Add(cbStatusTodo);
        panelRightSideBar.Controls.Add(panel1);
        panelRightSideBar.Controls.Add(tbCurrentTodoNote);
        panelRightSideBar.Controls.Add(label2);
        panelRightSideBar.Controls.Add(dtpCurrentTodoDueDate);
        panelRightSideBar.Controls.Add(lbCurrentTodoName);
        panelRightSideBar.Dock = DockStyle.Right;
        panelRightSideBar.Location = new Point(1102, 67);
        panelRightSideBar.Margin = new Padding(3, 4, 3, 4);
        panelRightSideBar.Name = "panelRightSideBar";
        panelRightSideBar.Size = new Size(343, 894);
        panelRightSideBar.TabIndex = 2;
        // 
        // lbCurrentTodoTagName
        // 
        lbCurrentTodoTagName.AutoSize = true;
        lbCurrentTodoTagName.Font = new Font("Segoe UI", 10F);
        lbCurrentTodoTagName.Location = new Point(122, 52);
        lbCurrentTodoTagName.Name = "lbCurrentTodoTagName";
        lbCurrentTodoTagName.Size = new Size(22, 23);
        lbCurrentTodoTagName.TabIndex = 10;
        lbCurrentTodoTagName.Text = "...";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 10F);
        label1.Location = new Point(7, 52);
        label1.Name = "label1";
        label1.Size = new Size(90, 23);
        label1.TabIndex = 9;
        label1.Text = "Danh sách";
        // 
        // cbStatusTodo
        // 
        cbStatusTodo.AutoSize = true;
        cbStatusTodo.Location = new Point(7, 11);
        cbStatusTodo.Margin = new Padding(3, 4, 3, 4);
        cbStatusTodo.Name = "cbStatusTodo";
        cbStatusTodo.Size = new Size(18, 17);
        cbStatusTodo.TabIndex = 8;
        cbStatusTodo.UseVisualStyleBackColor = true;
        cbStatusTodo.CheckedChanged += cbStatusTodo_CheckedChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(btnHideRightSideBar);
        panel1.Controls.Add(btnDeleteTodo);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 854);
        panel1.Margin = new Padding(3, 4, 3, 4);
        panel1.Name = "panel1";
        panel1.Size = new Size(343, 40);
        panel1.TabIndex = 7;
        // 
        // btnHideRightSideBar
        // 
        btnHideRightSideBar.BackColor = SystemColors.MenuHighlight;
        btnHideRightSideBar.Dock = DockStyle.Left;
        btnHideRightSideBar.FlatStyle = FlatStyle.Flat;
        btnHideRightSideBar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnHideRightSideBar.ForeColor = SystemColors.Window;
        btnHideRightSideBar.Location = new Point(0, 0);
        btnHideRightSideBar.Margin = new Padding(3, 4, 3, 4);
        btnHideRightSideBar.Name = "btnHideRightSideBar";
        btnHideRightSideBar.Size = new Size(86, 40);
        btnHideRightSideBar.TabIndex = 1;
        btnHideRightSideBar.Text = "<-";
        btnHideRightSideBar.UseVisualStyleBackColor = false;
        btnHideRightSideBar.Click += btnHideRightSideBar_Click;
        // 
        // btnDeleteTodo
        // 
        btnDeleteTodo.BackColor = Color.FromArgb(255, 192, 192);
        btnDeleteTodo.Dock = DockStyle.Right;
        btnDeleteTodo.FlatStyle = FlatStyle.Flat;
        btnDeleteTodo.Location = new Point(257, 0);
        btnDeleteTodo.Margin = new Padding(3, 4, 3, 4);
        btnDeleteTodo.Name = "btnDeleteTodo";
        btnDeleteTodo.Size = new Size(86, 40);
        btnDeleteTodo.TabIndex = 0;
        btnDeleteTodo.Text = "Xóa";
        btnDeleteTodo.UseVisualStyleBackColor = false;
        btnDeleteTodo.Click += btnDeleteTodo_Click;
        // 
        // tbCurrentTodoNote
        // 
        tbCurrentTodoNote.Location = new Point(7, 133);
        tbCurrentTodoNote.Margin = new Padding(3, 4, 3, 4);
        tbCurrentTodoNote.Multiline = true;
        tbCurrentTodoNote.Name = "tbCurrentTodoNote";
        tbCurrentTodoNote.PlaceholderText = "Thêm ghi chú";
        tbCurrentTodoNote.Size = new Size(322, 131);
        tbCurrentTodoNote.TabIndex = 6;
        tbCurrentTodoNote.Leave += tbCurrentTodoNote_Leave;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 10F);
        label2.Location = new Point(7, 95);
        label2.Name = "label2";
        label2.Size = new Size(118, 23);
        label2.TabIndex = 5;
        label2.Text = "Ngày đến hạn";
        // 
        // dtpCurrentTodoDueDate
        // 
        dtpCurrentTodoDueDate.Format = DateTimePickerFormat.Short;
        dtpCurrentTodoDueDate.Location = new Point(122, 95);
        dtpCurrentTodoDueDate.Margin = new Padding(3, 4, 3, 4);
        dtpCurrentTodoDueDate.Name = "dtpCurrentTodoDueDate";
        dtpCurrentTodoDueDate.Size = new Size(206, 27);
        dtpCurrentTodoDueDate.TabIndex = 4;
        dtpCurrentTodoDueDate.ValueChanged += dtpCurrentTodoDueDate_ValueChanged;
        // 
        // lbCurrentTodoName
        // 
        lbCurrentTodoName.AutoSize = true;
        lbCurrentTodoName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lbCurrentTodoName.Location = new Point(30, 1);
        lbCurrentTodoName.Name = "lbCurrentTodoName";
        lbCurrentTodoName.Size = new Size(31, 30);
        lbCurrentTodoName.TabIndex = 2;
        lbCurrentTodoName.Text = "...";
        // 
        // panelMainContent
        // 
        panelMainContent.BackColor = SystemColors.Control;
        panelMainContent.Controls.Add(panel6);
        panelMainContent.Controls.Add(panel2);
        panelMainContent.Dock = DockStyle.Fill;
        panelMainContent.Location = new Point(286, 67);
        panelMainContent.Margin = new Padding(3, 4, 3, 4);
        panelMainContent.Name = "panelMainContent";
        panelMainContent.Size = new Size(816, 894);
        panelMainContent.TabIndex = 3;
        // 
        // panel6
        // 
        panel6.Controls.Add(dgvTodos);
        panel6.Dock = DockStyle.Fill;
        panel6.Location = new Point(0, 133);
        panel6.Margin = new Padding(3, 4, 3, 4);
        panel6.Name = "panel6";
        panel6.Size = new Size(816, 761);
        panel6.TabIndex = 7;
        // 
        // dgvTodos
        // 
        dgvTodos.AllowUserToAddRows = false;
        dgvTodos.AllowUserToDeleteRows = false;
        dgvTodos.AllowUserToResizeColumns = false;
        dgvTodos.AllowUserToResizeRows = false;
        dgvTodos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTodos.BackgroundColor = SystemColors.Control;
        dgvTodos.BorderStyle = BorderStyle.None;
        dgvTodos.CellBorderStyle = DataGridViewCellBorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvTodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTodos.ColumnHeadersVisible = false;
        dgvTodos.Dock = DockStyle.Bottom;
        dgvTodos.Location = new Point(0, 0);
        dgvTodos.Margin = new Padding(3, 4, 3, 4);
        dgvTodos.Name = "dgvTodos";
        dgvTodos.ReadOnly = true;
        dgvTodos.RowHeadersVisible = false;
        dgvTodos.RowHeadersWidth = 51;
        dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dgvTodos.RowsDefaultCellStyle = dataGridViewCellStyle3;
        dgvTodos.Size = new Size(816, 761);
        dgvTodos.TabIndex = 3;
        dgvTodos.CellClick += dgvTodos_CellClick;
        dgvTodos.CellContentClick += dgvTodos_CellContentClick;
        // 
        // panel2
        // 
        panel2.Controls.Add(panel5);
        panel2.Controls.Add(panel4);
        panel2.Controls.Add(panel3);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(0, 0);
        panel2.Margin = new Padding(3, 4, 3, 4);
        panel2.Name = "panel2";
        panel2.Size = new Size(816, 133);
        panel2.TabIndex = 6;
        // 
        // panel5
        // 
        panel5.Controls.Add(cbSort);
        panel5.Controls.Add(lbTagName);
        panel5.Controls.Add(btnTagMenu);
        panel5.Dock = DockStyle.Fill;
        panel5.Location = new Point(0, 0);
        panel5.Margin = new Padding(3, 4, 3, 4);
        panel5.Name = "panel5";
        panel5.Size = new Size(816, 52);
        panel5.TabIndex = 8;
        // 
        // cbSort
        // 
        cbSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        cbSort.FormattingEnabled = true;
        cbSort.Items.AddRange(new object[] { "Theo hạn", "Theo bảng chữ cái" });
        cbSort.Location = new Point(637, 13);
        cbSort.Margin = new Padding(3, 4, 3, 4);
        cbSort.Name = "cbSort";
        cbSort.Size = new Size(172, 28);
        cbSort.TabIndex = 7;
        cbSort.Text = "- Sắp xếp -";
        cbSort.SelectedIndexChanged += cbSort_SelectedIndexChanged;
        // 
        // lbTagName
        // 
        lbTagName.AutoSize = true;
        lbTagName.Dock = DockStyle.Fill;
        lbTagName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lbTagName.Location = new Point(45, 0);
        lbTagName.Name = "lbTagName";
        lbTagName.Size = new Size(31, 30);
        lbTagName.TabIndex = 0;
        lbTagName.Text = "...";
        // 
        // btnTagMenu
        // 
        btnTagMenu.BackColor = SystemColors.MenuHighlight;
        btnTagMenu.Dock = DockStyle.Left;
        btnTagMenu.FlatAppearance.BorderSize = 0;
        btnTagMenu.FlatStyle = FlatStyle.Flat;
        btnTagMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnTagMenu.ForeColor = SystemColors.Window;
        btnTagMenu.Location = new Point(0, 0);
        btnTagMenu.Margin = new Padding(3, 4, 3, 4);
        btnTagMenu.Name = "btnTagMenu";
        btnTagMenu.Size = new Size(45, 52);
        btnTagMenu.TabIndex = 5;
        btnTagMenu.Text = "V";
        btnTagMenu.UseVisualStyleBackColor = false;
        btnTagMenu.Click += btnTagMenu_Click;
        // 
        // panel4
        // 
        panel4.Controls.Add(tbCreateTodo);
        panel4.Dock = DockStyle.Bottom;
        panel4.Location = new Point(0, 52);
        panel4.Margin = new Padding(3, 4, 3, 4);
        panel4.Name = "panel4";
        panel4.Size = new Size(816, 44);
        panel4.TabIndex = 7;
        // 
        // tbCreateTodo
        // 
        tbCreateTodo.Dock = DockStyle.Fill;
        tbCreateTodo.Font = new Font("Segoe UI", 11F);
        tbCreateTodo.Location = new Point(0, 0);
        tbCreateTodo.Margin = new Padding(3, 4, 3, 4);
        tbCreateTodo.Name = "tbCreateTodo";
        tbCreateTodo.PlaceholderText = " + Thêm tác vụ";
        tbCreateTodo.Size = new Size(816, 32);
        tbCreateTodo.TabIndex = 1;
        tbCreateTodo.TextChanged += tbCreateTodo_TextChanged;
        tbCreateTodo.KeyDown += tbCreateTodo_KeyDown;
        // 
        // panel3
        // 
        panel3.Controls.Add(dtpCreateTodo);
        panel3.Controls.Add(btnCreateTodo);
        panel3.Dock = DockStyle.Bottom;
        panel3.Location = new Point(0, 96);
        panel3.Margin = new Padding(3, 4, 3, 4);
        panel3.Name = "panel3";
        panel3.Size = new Size(816, 37);
        panel3.TabIndex = 6;
        // 
        // dtpCreateTodo
        // 
        dtpCreateTodo.Dock = DockStyle.Left;
        dtpCreateTodo.Format = DateTimePickerFormat.Short;
        dtpCreateTodo.Location = new Point(0, 0);
        dtpCreateTodo.Margin = new Padding(3, 4, 3, 4);
        dtpCreateTodo.Name = "dtpCreateTodo";
        dtpCreateTodo.Size = new Size(116, 27);
        dtpCreateTodo.TabIndex = 2;
        // 
        // btnCreateTodo
        // 
        btnCreateTodo.BackColor = SystemColors.MenuHighlight;
        btnCreateTodo.Dock = DockStyle.Right;
        btnCreateTodo.Enabled = false;
        btnCreateTodo.FlatStyle = FlatStyle.Flat;
        btnCreateTodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCreateTodo.ForeColor = SystemColors.Window;
        btnCreateTodo.Location = new Point(730, 0);
        btnCreateTodo.Margin = new Padding(3, 4, 3, 4);
        btnCreateTodo.Name = "btnCreateTodo";
        btnCreateTodo.Size = new Size(86, 37);
        btnCreateTodo.TabIndex = 4;
        btnCreateTodo.Text = "Thêm";
        btnCreateTodo.UseVisualStyleBackColor = false;
        btnCreateTodo.Click += btnCreateTodo_Click;
        // 
        // cmsUserMenu
        // 
        cmsUserMenu.ImageScalingSize = new Size(20, 20);
        cmsUserMenu.Items.AddRange(new ToolStripItem[] { miExportFile, miLogin, miRegister, toolStripSeparator1, miLogout });
        cmsUserMenu.Items.AddRange(new ToolStripItem[] { miExportFile, miChangePassword, miLogin, miRegister, toolStripSeparator1, miLogout });
        cmsUserMenu.Name = "cmsUserMenu";
        cmsUserMenu.Size = new Size(172, 106);
        // 
        // miExportFile
        // 
        miExportFile.Name = "miExportFile";
        miExportFile.Size = new Size(171, 24);
        miExportFile.Text = "Xuất file Excel";
        miExportFile.Click += miExportFile_Click;
        // 
        // miLogin
        // 
        miLogin.Name = "miLogin";
        miLogin.Size = new Size(171, 24);
        miLogin.Text = "Đăng nhập";
        miLogin.Click += miLogin_Click;
        // 
        // miRegister
        // 
        miRegister.Name = "miRegister";
        miRegister.Size = new Size(171, 24);
        miRegister.Text = "Đăng ký";
        miRegister.Click += miRegister_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(168, 6);
        // 
        // miLogout
        // 
        miLogout.Name = "miLogout";
        miLogout.Size = new Size(171, 24);
        miLogout.Text = "Đăng xuất";
        miLogout.Click += miLogout_Click;
        // 
        // miChangePassword
        // 
        miChangePassword.Name = "miChangePassword";
        miChangePassword.Size = new Size(146, 22);
        miChangePassword.Text = "Đổi mật khẩu";
        miChangePassword.Click += miChangePassword_Click;
        // 
        // cmsTagMenu
        // 
        cmsTagMenu.ImageScalingSize = new Size(20, 20);
        cmsTagMenu.Items.AddRange(new ToolStripItem[] { miDrawChart, toolStripSeparator2, miDeleteTag, miShowCalendar });
        cmsTagMenu.Name = "contextMenuStrip1";
        cmsTagMenu.Size = new Size(175, 82);
        // 
        // miDrawChart
        // 
        miDrawChart.Name = "miDrawChart";
        miDrawChart.Size = new Size(174, 24);
        miDrawChart.Text = "Vẽ biểu đồ";
        miDrawChart.Click += miDrawChart_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(171, 6);
        // 
        // miDeleteTag
        // 
        miDeleteTag.Name = "miDeleteTag";
        miDeleteTag.Size = new Size(174, 24);
        miDeleteTag.Text = "Xóa danh sách";
        miDeleteTag.Click += miDeleteTag_Click;
        // 
        // miShowCalendar
        // 
        miShowCalendar.Name = "miShowCalendar";
        miShowCalendar.Size = new Size(174, 24);
        miShowCalendar.Text = "Lịch";
        miShowCalendar.Click += miShowCalendar_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1445, 961);
        Controls.Add(panelMainContent);
        Controls.Add(panelRightSideBar);
        Controls.Add(panelLeftSideBar);
        Controls.Add(panelHeader);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 5, 3, 5);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Task Manager";
        Load += MainForm_Load;
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        panelLeftSideBar.ResumeLayout(false);
        panelLeftSideBar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
        panelRightSideBar.ResumeLayout(false);
        panelRightSideBar.PerformLayout();
        panel1.ResumeLayout(false);
        panelMainContent.ResumeLayout(false);
        panel6.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dgvTodos).EndInit();
        panel2.ResumeLayout(false);
        panel5.ResumeLayout(false);
        panel5.PerformLayout();
        panel4.ResumeLayout(false);
        panel4.PerformLayout();
        panel3.ResumeLayout(false);
        cmsUserMenu.ResumeLayout(false);
        cmsTagMenu.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.ContextMenuStrip cmsTagMenu;

    private System.Windows.Forms.Button btnTagMenu;

    #endregion
    private System.Windows.Forms.SaveFileDialog sfdExcel;
    private System.Windows.Forms.Panel panelHeader;
    private System.Windows.Forms.Panel panelLeftSideBar;
    private System.Windows.Forms.Panel panelRightSideBar;
    private System.Windows.Forms.Panel panelMainContent;
    private Button btnToggleLeftSideBar;
    private System.Windows.Forms.DataGridView dgvTags;
    private TextBox tbCreateTag;
    private TextBox tbCreateTodo;
    private System.Windows.Forms.Label lbTagName;
    private System.Windows.Forms.DataGridView dgvTodos;
    private DateTimePicker dtpCreateTodo;
    private Button btnHideRightSideBar;
    private Button btnDeleteTodo;
    private Label lbCurrentTodoName;
    private Label label2;
    private DateTimePicker dtpCurrentTodoDueDate;
    private Label label3;
    private TextBox tbCurrentTodoNote;
    private Button btnCreateTodo;
    private TextBox tbSearchTodo;
    private Button btnUserMenu;
    private ContextMenuStrip cmsUserMenu;
    private ToolStripMenuItem miExportFile;
    private ToolStripMenuItem miLogin;
    private ToolStripMenuItem miRegister;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem miLogout;
    private System.Windows.Forms.Panel panel1;
    private ToolStripMenuItem miDrawChart;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem miDeleteTag;
    private Panel panel2;
    private Panel panel4;
    private Panel panel3;
    private Panel panel5;
    private Panel panel6;
    private CheckBox cbStatusTodo;
    private Button btnSearch;
    private Label lbCurrentTodoTagName;
    private Label label1;
    private ComboBox cbSort;
    private ToolStripMenuItem miShowCalendar;
    private ToolStripMenuItem miChangePassword;

}
