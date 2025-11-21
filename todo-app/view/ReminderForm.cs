using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo_app.view
{
    public partial class ReminderForm : Form
    {
        public ReminderForm(string reminderText)
        {
            InitializeComponent();
            lblReminderText.Text = reminderText;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
