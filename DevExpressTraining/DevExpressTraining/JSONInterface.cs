using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace DevExpressTraining
{
    public static class JSONInterface
    {
        #region public
        public static TodoItemList GetSavedTodoItems()
        {
            TodoItemList todoItemList = LoadTodoItems(JSONFilePath);
            return todoItemList;
        }

        public static void SaveTodoItems(TodoItemList todoItemList)
        {
            string filePath = JSONFilePath;
            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(AppFolder);
            }

            string json = JsonConvert.SerializeObject(todoItemList);
            File.WriteAllText(filePath, json);
        }
        #endregion

        #region private
        private static TodoItemList LoadTodoItems(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new TodoItemList();
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<TodoItemList>(json);
        }

        private static string JSONFilePath
        {
            get
            {
                string filePath = Path.Combine(AppFolder, "TodoItems.json");
                return filePath;
            }
        }

        private static string AppFolder
        {
            get
            {
                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string appFolder = Path.Combine(folderPath, "ErrolTodo");
                return appFolder;
            }
        }
        #endregion
    }
}
