namespace todo_app.view
{
    partial class Note
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
            groupNote = new GroupBox();
            Save = new Button();
            NoteContent = new TextBox();
            groupNote.SuspendLayout();
            SuspendLayout();
            // 
            // groupNote
            // 
            groupNote.Controls.Add(Save);
            groupNote.Controls.Add(NoteContent);
            groupNote.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupNote.Location = new Point(12, 12);
            groupNote.Name = "groupNote";
            groupNote.Size = new Size(630, 303);
            groupNote.TabIndex = 0;
            groupNote.TabStop = false;
            groupNote.Text = "Ghi chú";
            // 
            // Save
            // 
            Save.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Save.Location = new Point(27, 274);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 1;
            Save.Text = "Lưu";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // NoteContent
            // 
            NoteContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NoteContent.Location = new Point(27, 46);
            NoteContent.Multiline = true;
            NoteContent.Name = "NoteContent";
            NoteContent.ScrollBars = ScrollBars.Vertical;
            NoteContent.Size = new Size(581, 222);
            NoteContent.TabIndex = 0;
            NoteContent.TextChanged += NoteContent_TextChanged;
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 331);
            Controls.Add(groupNote);
            Name = "Note";
            Text = "Note";
            Load += Note_Load;
            groupNote.ResumeLayout(false);
            groupNote.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupNote;
        private TextBox NoteContent;
        private Button Save;
    }
}