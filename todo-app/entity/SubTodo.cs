using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo_app.entity
{
    public class SubTodo
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsDone { get; set; }
        public int? TodoId { get; set; }
    }
}
