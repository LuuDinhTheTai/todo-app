using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using todo_app.controller;
using todo_app.entity;
using todo_app.service;

namespace todo_app.view
{
    public partial class ReminderSettingForm : Form
    {
        private ReminderService _reminderService;
        private Todo _todo;
        public ReminderSettingForm(Controller controller, Todo todo)
        {
            InitializeComponent();
            _reminderService = controller.ReminderService;
            _todo = todo;
        }
        private void ReminderSettingForm_Load(object sender, EventArgs e)
        {
            if(_reminderService.ReminderExists(_todo.Id))
            {
                var reminderTime = _reminderService.GetReminderTime(_todo.Id);
                if (reminderTime.HasValue)
                {
                    dtpReminderDate.Value = reminderTime.Value;
                }
                lblReminderText.Text = "Cập nhật nhắc nhở cho công việc:";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var reminderDate = dtpReminderDate.Value;
            if (_reminderService.ReminderExists(_todo.Id))
            {
                if (MessageBox.Show("Nhắc nhở đã tồn tại cho công việc này. Bạn có muốn cập nhật lại không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _reminderService.UpdateReminder(_todo.Id, reminderDate);
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thêm nhắc nhở cho công việc này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _reminderService.CreateOrUpdateReminder(_todo.Id, reminderDate);
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
