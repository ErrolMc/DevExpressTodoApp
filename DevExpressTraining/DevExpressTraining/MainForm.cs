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
        private TodoItemList todoItemList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_OnLoad(object sender, EventArgs e)
        {
            todoItemList = JSONInterface.GetSavedTodoItems();
            foreach (TodoItem todoItem in todoItemList.todoItems)
            {
                AddTodoItemControl(todoItem);
            }
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

                    TodoItem todoItem = todoItemList.AddTodoItem(header, notes);
                    AddTodoItemControl(todoItem);

                    JSONInterface.SaveTodoItems(todoItemList);
                }
            }
        }

        private void AddTodoItemControl(TodoItem todoItem)
        {
            TodoItemControl todoItemControl = new TodoItemControl
            {
                Label = todoItem.Header,
                TodoItem = todoItem,
            };

            todoItemControl.Width = TodoLayoutPanel.Width;
            todoItemControl.DeleteClicked += TodoItem_DeleteClicked;
            TodoLayoutPanel.Controls.Add(todoItemControl);
        }

        private void TodoItem_DeleteClicked(object sender, EventArgs e)
        {
            TodoItemControl itemToRemove = sender as TodoItemControl;
            if (itemToRemove != null)
            {
                todoItemList.RemoveTodoItem(itemToRemove.TodoItem);
                JSONInterface.SaveTodoItems(todoItemList);

                TodoLayoutPanel.Controls.Remove(itemToRemove);
                itemToRemove.Dispose();
            }
        }
    }
}
