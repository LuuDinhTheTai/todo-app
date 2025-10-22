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
    public partial class Note : Form
    {
        private Controller _controller;
        private TodoService _todoService;

        private Todo? _currentTodo;
        public Note(Todo currentTodo, Controller controller)
        {
            InitializeComponent();
            _controller = controller;
            _todoService = controller.TodoService;
            _currentTodo = currentTodo;
        }

        private void Note_Load(object sender, EventArgs e)
        {
            LoadNoteContent();
        }

        private void LoadNoteContent()
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
