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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblOld = new Label();
            tbOld = new TextBox();
            lblNew = new Label();
            tbNew = new TextBox();
            lblConfirm = new Label();
            tbConfirm = new TextBox();
            btnChange = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblOld, 0, 0);
            tableLayoutPanel1.Controls.Add(tbOld, 1, 0);
            tableLayoutPanel1.Controls.Add(lblNew, 0, 1);
            tableLayoutPanel1.Controls.Add(tbNew, 1, 1);
            tableLayoutPanel1.Controls.Add(lblConfirm, 0, 2);
            tableLayoutPanel1.Controls.Add(tbConfirm, 1, 2);
            tableLayoutPanel1.Controls.Add(btnChange, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(14, 12);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableLayoutPanel1.Size = new Size(462, 171);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOld
            // 
            lblOld.AutoSize = true;
            lblOld.Dock = DockStyle.Fill;
            lblOld.Font = new Font("Segoe UI", 10F);
            lblOld.Location = new Point(3, 0);
            lblOld.Name = "lblOld";
            lblOld.Size = new Size(152, 32);
            lblOld.TabIndex = 0;
            lblOld.Text = "Mật khẩu cũ";
            lblOld.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbOld
            // 
            tbOld.Dock = DockStyle.Fill;
            tbOld.Font = new Font("Segoe UI", 10F);
            tbOld.Location = new Point(161, 2);
            tbOld.Margin = new Padding(3, 2, 3, 2);
            tbOld.Name = "tbOld";
            tbOld.PlaceholderText = "••••••••";
            tbOld.Size = new Size(298, 25);
            tbOld.TabIndex = 0;
            tbOld.UseSystemPasswordChar = true;
            // 
            // lblNew
            // 
            lblNew.AutoSize = true;
            lblNew.Dock = DockStyle.Fill;
            lblNew.Font = new Font("Segoe UI", 10F);
            lblNew.Location = new Point(3, 32);
            lblNew.Name = "lblNew";
            lblNew.Size = new Size(152, 32);
            lblNew.TabIndex = 1;
            lblNew.Text = "Mật khẩu mới";
            lblNew.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbNew
            // 
            tbNew.Dock = DockStyle.Fill;
            tbNew.Font = new Font("Segoe UI", 10F);
            tbNew.Location = new Point(161, 34);
            tbNew.Margin = new Padding(3, 2, 3, 2);
            tbNew.Name = "tbNew";
            tbNew.PlaceholderText = "••••••••";
            tbNew.Size = new Size(298, 25);
            tbNew.TabIndex = 1;
            tbNew.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Dock = DockStyle.Fill;
            lblConfirm.Font = new Font("Segoe UI", 10F);
            lblConfirm.Location = new Point(3, 64);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(152, 32);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Nhập lại mật khẩu";
            lblConfirm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbConfirm
            // 
            tbConfirm.Dock = DockStyle.Fill;
            tbConfirm.Font = new Font("Segoe UI", 10F);
            tbConfirm.Location = new Point(161, 66);
            tbConfirm.Margin = new Padding(3, 2, 3, 2);
            tbConfirm.Name = "tbConfirm";
            tbConfirm.PlaceholderText = "••••••••";
            tbConfirm.Size = new Size(298, 25);
            tbConfirm.TabIndex = 2;
            tbConfirm.UseSystemPasswordChar = true;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.Right;
            btnChange.BackColor = SystemColors.MenuHighlight;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChange.ForeColor = SystemColors.Window;
            btnChange.Location = new Point(316, 123);
            btnChange.Margin = new Padding(0, 6, 0, 0);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(146, 27);
            btnChange.TabIndex = 3;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // ChangePasswordForm
            // 
            AcceptButton = btnChange;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 195);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ChangePasswordForm";
            Padding = new Padding(14, 12, 14, 12);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đổi mật khẩu";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }
    }
}
