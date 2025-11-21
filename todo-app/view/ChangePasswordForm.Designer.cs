namespace todo_app.view
{
    partial class ChangePasswordForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox tbOld;
        private TextBox tbNew;
        private TextBox tbConfirm;
        private Button btnChange;

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblOld;
        private Label lblNew;
        private Label lblConfirm;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblOld = new Label();
            lblNew = new Label();
            lblConfirm = new Label();
            tbOld = new TextBox();
            tbNew = new TextBox();
            tbConfirm = new TextBox();
            btnChange = new Button();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOld
            // 
            lblOld.AutoSize = true;
            lblOld.Font = new Font("Segoe UI", 10F);
            lblOld.Text = "Mật khẩu cũ";
            lblOld.TextAlign = ContentAlignment.MiddleLeft;
            lblOld.Dock = DockStyle.Fill;
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Font = new Font("Segoe UI", 10F);
            lblNew.Text = "Mật khẩu mới";
            lblNew.TextAlign = ContentAlignment.MiddleLeft;
            lblNew.Dock = DockStyle.Fill;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 10F);
            lblConfirm.Text = "Nhập lại mật khẩu";
            lblConfirm.TextAlign = ContentAlignment.MiddleLeft;
            lblConfirm.Dock = DockStyle.Fill;
            // 
            // tbOld
            // 
            tbOld.Font = new Font("Segoe UI", 10F);
            tbOld.PlaceholderText = "••••••••";
            tbOld.UseSystemPasswordChar = true;
            tbOld.Dock = DockStyle.Fill;
            tbOld.TabIndex = 0;
            // 
            // tbNew
            // 
            tbNew.Font = new Font("Segoe UI", 10F);
            tbNew.PlaceholderText = "••••••••";
            tbNew.UseSystemPasswordChar = true;
            tbNew.Dock = DockStyle.Fill;
            tbNew.TabIndex = 1;
            // 
            // tbConfirm
            // 
            tbConfirm.Font = new Font("Segoe UI", 10F);
            tbConfirm.PlaceholderText = "••••••••";
            tbConfirm.UseSystemPasswordChar = true;
            tbConfirm.Dock = DockStyle.Fill;
            tbConfirm.TabIndex = 2;
            // 
            // btnChange
            // 
            btnChange.Text = "Đổi mật khẩu";
            btnChange.BackColor = SystemColors.MenuHighlight;
            btnChange.ForeColor = SystemColors.Window;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChange.Size = new Size(180, 36);
            btnChange.Anchor = AnchorStyles.Right;
            btnChange.Margin = new Padding(0, 8, 0, 0);
            btnChange.TabIndex = 3;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // add controls into table
            // 
            tableLayoutPanel1.Controls.Add(lblOld, 0, 0);
            tableLayoutPanel1.Controls.Add(tbOld, 1, 0);
            tableLayoutPanel1.Controls.Add(lblNew, 0, 1);
            tableLayoutPanel1.Controls.Add(tbNew, 1, 1);
            tableLayoutPanel1.Controls.Add(lblConfirm, 0, 2);
            tableLayoutPanel1.Controls.Add(tbConfirm, 1, 2);
            tableLayoutPanel1.Controls.Add(btnChange, 1, 3);
            // 
            // ChangePasswordForm
            // 
            AcceptButton = btnChange;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 260); // cửa sổ lớn hơn
            Padding = new Padding(16);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            ResumeLayout(false);
        }
    }
}
