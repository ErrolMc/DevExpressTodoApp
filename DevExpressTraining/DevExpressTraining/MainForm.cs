using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpressTraining
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_OnLoad(object sender, EventArgs e)
        {

        }

        private void AddTodoButton_OnClick(object sender, EventArgs e)
        {
            using (AddTodoForm addForm = new AddTodoForm())
            {
                DialogResult result = addForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string header = addForm.HeaderText;
                    string notes = addForm.NotesText;

                    TodoItemControl todoItem = new TodoItemControl
                    {
                        Label = header
                    };

                    todoItem.Width = TodoLayoutPanel.Width;
                    todoItem.DeleteClicked += TodoItem_DeleteClicked;
                    TodoLayoutPanel.Controls.Add(todoItem);
                }
            }
        }

        private void TodoItem_DeleteClicked(object sender, EventArgs e)
        {
            TodoItemControl itemToRemove = sender as TodoItemControl;
            if (itemToRemove != null)
            {
                TodoLayoutPanel.Controls.Remove(itemToRemove);
                itemToRemove.Dispose();
            }
        }
    }
}
