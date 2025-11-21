using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Bibliography;
using todo_app.entity;

namespace todo_app.view
{
    public partial class UserControlDay : UserControl
    {
        string _day;
        List<Todo>? _todos;
        
        public UserControlDay(string day, List<Todo>? todos)
        {
            InitializeComponent();
            _day = day;
            _todos = todos;
            lbDay.Text = day;
            
            DisplayTodos();
        }

        private void DisplayTodos()
        {
            if (_todos == null || _todos.Count == 0)
            {
                tbCalendarTodo.Text = "";
                tbCalendarTodo.ScrollBars = ScrollBars.None;
                lbDay.BackColor = Color.LightBlue;
                lbDayHeader.BackColor = Color.LightBlue;
                return;
            }
            
            bool allDone = _todos.All(t => t.IsDone);
            
            if (allDone)
            {
                lbDayHeader.BackColor = Color.LightGreen;
                lbDay.BackColor = Color.LightGreen;
            }
            else
            {
                lbDayHeader.BackColor = Color.LightCoral;
                lbDay.BackColor = Color.LightCoral;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var todo in _todos)
            {
                string prefix = todo.IsDone ? "✓ " : "x ";
                sb.AppendLine(prefix + todo.Content);
            }
            tbCalendarTodo.Text = sb.ToString().TrimEnd();
            
            using (Graphics g = tbCalendarTodo.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(tbCalendarTodo.Text, tbCalendarTodo.Font, tbCalendarTodo.Width);
                tbCalendarTodo.ScrollBars = textSize.Height > tbCalendarTodo.Height ? ScrollBars.Vertical : ScrollBars.None;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

    }
}
