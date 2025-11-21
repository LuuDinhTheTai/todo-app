using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using todo_app.controller;
using todo_app.entity;
using todo_app.service;

namespace todo_app.view
{
    public partial class CalendarForm : Form
    {
        private Controller _controller;
        private TodoService _todoService;
        private Tag? _currentTag = null;
        private List<Todo> _todos;

        public static int _year, _month;

        public CalendarForm(Controller controller, Tag currentTag)
        {
            InitializeComponent();
            _controller = controller;
            _todoService = controller.TodoService;
            _currentTag = currentTag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_currentTag != null)
            {
                lbTag.Text = _currentTag.Name;
                _todos = _todoService.FindByTagId(_currentTag.Id);
            }
            ShowDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void ShowDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;


            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lbMonthName.Text = monthName + " " + year;
            DateTime startOfTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i < week; i++)
            {
                UserControlDay uc = new UserControlDay("", null);
                flowLayoutPanel1.Controls.Add(uc);
            }

            for (int i = 1; i <= day; i++)
            {
                DateTime currentDate = new DateTime(year, month, i);

                List<Todo> todosForDay = _todos.Where(t => t.DueDate.HasValue &&
                    t.DueDate.Value.Date == currentDate.Date).ToList();

                UserControlDay uc = new UserControlDay(i + "", todosForDay);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 12;
                _year -= 1;
            }
            ShowDays(_month, _year);
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            ShowDays(_month, _year);
        }

    }
}
