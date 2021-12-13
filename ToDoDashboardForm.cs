using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheToDoList
{
    public partial class ToDoDashboardForm : Form, IToDoRequester
    {
        private List<ToDo> availableToDos = new List<ToDo>();
        public ToDoDashboardForm()
        {
            InitializeComponent();
            CreateSampleData();
            GenerateList();
        }

        private void CreateSampleData()
        {
            availableToDos.Add(new ToDo { ToDoTask = "Clean my room" });
            availableToDos.Add(new ToDo { ToDoTask = "Make my bed" });
        }

        private void GenerateList()
        {
            todosListBox.DataSource = null;

            todosListBox.DataSource = availableToDos;
            todosListBox.DisplayMember = "TaskDesc";
        }

        public void ToDoComplete(ToDo todo)
        {
            availableToDos.Add(todo);
            GenerateList();
        }

        private void createNewToDoButton_Click(object sender, EventArgs e)
        {
            CreateToDoForm frm = new CreateToDoForm(this);
            frm.Show();
        }

        private void deleteSelectedTaskButton_Click(object sender, EventArgs e)
        {
            ToDo t = (ToDo)todosListBox.SelectedItem;

            if (t != null)
            {
                availableToDos.Remove(t);

                GenerateList();
            }
        }
    }
}
