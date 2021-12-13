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
    public partial class CreateToDoForm : Form
    {
        IToDoRequester callingForm;

        public CreateToDoForm(IToDoRequester caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void createNewToDoButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ToDo todo = new ToDo(createNewToDoTextBox.Text);

                callingForm.ToDoComplete(todo);

                MessageBox.Show("New Todo created!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid information in form. Please try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (createNewToDoTextBox.Text.Length == 0)
                output = false;

            return output;
        }

        private void cancelCreateToDoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
