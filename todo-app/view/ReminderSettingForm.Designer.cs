namespace todo_app.view
{
    partial class ReminderSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblReminderText = new Label();
            dtpReminderDate = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblReminderText
            // 
            lblReminderText.Font = new Font("Segoe UI", 10.2F);
            lblReminderText.Location = new Point(29, 9);
            lblReminderText.Name = "lblReminderText";
            lblReminderText.Size = new Size(276, 36);
            lblReminderText.TabIndex = 1;
            lblReminderText.Text = "Chọn ngày nhắc nhở";
            lblReminderText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpReminderDate
            // 
            dtpReminderDate.Format = DateTimePickerFormat.Time;
            dtpReminderDate.Location = new Point(113, 50);
            dtpReminderDate.Name = "dtpReminderDate";
            dtpReminderDate.Size = new Size(108, 23);
            dtpReminderDate.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(50, 87);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 87);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 27);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ReminderSettingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 128);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpReminderDate);
            Controls.Add(lblReminderText);
            Name = "ReminderSettingForm";
            Text = "Cài đặt nhắc nhở";
            Load += ReminderSettingForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblReminderText;
        private DateTimePicker dtpReminderDate;
        private Button btnSave;
        private Button btnCancel;
    }
}