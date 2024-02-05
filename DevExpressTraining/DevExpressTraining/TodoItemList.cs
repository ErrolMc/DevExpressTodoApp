
using System.Collections.Generic;

namespace DevExpressTraining
{
    public class TodoItemList
    {
        public List<TodoItem> todoItems { get; set; }

        public TodoItemList()
        {
            todoItems = new List<TodoItem>();
        }

        public TodoItem AddTodoItem(string header, string notes)
        {
            TodoItem todoItem = new TodoItem();
            todoItem.Header = header;
            todoItem.Notes = notes;

            todoItems.Add(todoItem);
            return todoItem;
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
    }
}
