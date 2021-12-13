using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheToDoList
{
    public interface IToDoRequester
    {
        public void ToDoComplete(ToDo todo);
    }
}
