
using System.Collections.Generic;

namespace DevExpressTraining
{
    public class TodoItemList
    {
        public List<TodoItem> todoItems { get; set; }
        public List<TodoItem> completedItems { get; set; }

        public TodoItemList()
        {
            todoItems = new List<TodoItem>();
            completedItems = new List<TodoItem>();
        }

        public TodoItem AddTodoItem(string header, string notes)
        {
            TodoItem todoItem = new TodoItem();
            todoItem.Header = header;
            todoItem.Notes = notes;
            todoItem.Completed = false;

            todoItems.Add(todoItem);
            return todoItem;
        }

        public void AddTodoItem(TodoItem todoItem)
        {
            todoItems.Add(todoItem);
        }

        public void AddCompletedItem(TodoItem todoItem)
        {
            completedItems.Add(todoItem);
        }

        public bool RemoveTodoItem(TodoItem todoItem)
        {
            if (todoItems.Contains(todoItem))
            {
                todoItems.Remove(todoItem);
                return true;
            }
            return false;
        }

        public bool RemoveCompletedItem(TodoItem todoItem)
        {
            if (completedItems.Contains(todoItem))
            {
                completedItems.Remove(todoItem);
                return true;
            }
            return false;
        }
    }
}
