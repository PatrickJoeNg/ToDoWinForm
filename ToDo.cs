using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheToDoList
{
    public class ToDo
    {
        public string ToDoTask { get; set; }

        public string TaskDesc
        {
            get { return $"{ ToDoTask }"; }
        }
        public ToDo()
        {

        }

        public ToDo(string toDoTaskDesc)
        {
            ToDoTask = toDoTaskDesc;
        }
    }
}
