using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpressTraining
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        private TodoItemList todoItemList;
        private CompletedSpacerControl completedSpacerControl;
        private const int CONTROL_MARGIN = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_OnLoad(object sender, EventArgs e)
        {
            todoItemList = JSONInterface.GetSavedTodoItems();
            foreach (TodoItem todoItem in todoItemList.todoItems)
                AddTodoItemControl(todoItem, false);

            CreateCompletedSpacer();
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
                    AddTodoItemControl(todoItem, false, todoItemList.todoItems.Count);

                    SaveTodoItems(this, EventArgs.Empty);
                }
            }
        }

        private void AddTodoItemControl(TodoItem todoItem, bool completed, int index = -1)
        {
            TodoItemControl todoItemControl = new TodoItemControl
            {
                Label = todoItem.Header,
                Notes = todoItem.Notes,
                TodoItem = todoItem,
                Completed = completed,
            };

            todoItemControl.Width = TodoLayoutPanel.Width - CONTROL_MARGIN;
            todoItemControl.DeleteClicked += TodoItem_DeleteClicked;
            todoItemControl.CheckedChanged += TodoItem_CheckedChanged;
            todoItemControl.SaveTodoItems += SaveTodoItems;
            TodoLayoutPanel.Controls.Add(todoItemControl);

            if (index != -1)
                TodoLayoutPanel.Controls.SetChildIndex(todoItemControl, todoItemList.todoItems.Count - 1);
        }

        private void CreateCompletedSpacer()
        {
            void AddSpacer()
            {
                Panel spacer = new Panel();
                spacer.Height = 10;
                spacer.Width = TodoLayoutPanel.Width - CONTROL_MARGIN;
                spacer.BackColor = Color.Transparent;
                TodoLayoutPanel.Controls.Add(spacer);
            }

            AddSpacer();
            
            completedSpacerControl = new CompletedSpacerControl();
            TodoLayoutPanel.Controls.Add(completedSpacerControl);
            completedSpacerControl.OnToggleExpanded += OnCompletedExpandedToggle;
            completedSpacerControl.SetCompletedNum(todoItemList.completedItems.Count);

            AddSpacer();
        }

        private void TodoItem_DeleteClicked(object sender, EventArgs e)
        {
            TodoItemControl itemToRemove = sender as TodoItemControl;
            if (itemToRemove != null)
            {
                TodoItem todoItem = itemToRemove.TodoItem;
                if (todoItem.Completed)
                {
                    todoItemList.RemoveCompletedItem(todoItem);
                    completedSpacerControl.SetCompletedNum(todoItemList.completedItems.Count);
                }
                else
                    todoItemList.RemoveTodoItem(todoItem);

                SaveTodoItems(this, EventArgs.Empty);

                TodoLayoutPanel.Controls.Remove(itemToRemove);
                itemToRemove.Dispose();
            }
        }

        private void TodoItem_CheckedChanged(object sender, EventArgs e)
        {
            TodoItemControl itemControl = sender as TodoItemControl;
            if (itemControl != null)
            {
                TodoItem todoItem = itemControl.TodoItem;

                if (todoItem.Completed)
                {
                    todoItemList.RemoveTodoItem(todoItem);
                    todoItemList.AddCompletedItem(todoItem);

                    if (completedSpacerControl.IsExpanded)
                        TodoLayoutPanel.Controls.SetChildIndex(itemControl, TodoLayoutPanel.Controls.Count - 1);
                    else
                    {
                        TodoLayoutPanel.Controls.Remove(itemControl);
                        itemControl.Dispose();
                    }
                }
                else
                {
                    todoItemList.RemoveCompletedItem(todoItem);
                    todoItemList.AddTodoItem(todoItem);
                    TodoLayoutPanel.Controls.SetChildIndex(itemControl, todoItemList.todoItems.Count - 1);
                }

                completedSpacerControl.SetCompletedNum(todoItemList.completedItems.Count);
                SaveTodoItems(this, EventArgs.Empty);
            }
        }

        private void OnCompletedExpandedToggle(object sender, EventArgs e)
        {
            bool expanded = completedSpacerControl.IsExpanded;

            if (expanded)
            {
                foreach (TodoItem todoItem in todoItemList.completedItems)
                {
                    AddTodoItemControl(todoItem, true);
                }
            }
            else
            {
                for (int i = 0; i < TodoLayoutPanel.Controls.Count; i++)
                {
                    Control control = TodoLayoutPanel.Controls[i];
                    TodoItemControl itemControl = control as TodoItemControl;
                    if (itemControl != null)
                    {
                        TodoItem todoItem = itemControl.TodoItem;
                        if (todoItem.Completed)
                        {
                            TodoLayoutPanel.Controls.Remove(control);
                            control.Dispose();
                            i--;
                        }
                    }
                }
            }
        }

        private void SaveTodoItems(object sender, EventArgs e)
        {
            JSONInterface.SaveTodoItems(todoItemList);
        }
    }
}
