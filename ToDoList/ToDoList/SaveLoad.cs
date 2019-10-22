using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ToDoList
{
    public class SaveLoad
    {
        private static string path = @"tasks.txt";

        public static void SaveTasks()
        {            
            string save = "";
            if (File.Exists(path))
            {
                foreach (var item in TasksList.taskList)
                {
                    save += $"{item.Description};{item.DateStart};{item.DateEnd};{item.AllDayTask};{item.ImportantTask}\n";
                }
                File.WriteAllText(path, save);
            }
            else
            {
                File.Create(path);
                foreach (var item in TasksList.taskList)
                {
                    File.WriteAllText(path, $"{item.Description};{item.DateStart};{item.DateEnd};{item.AllDayTask};{item.ImportantTask}\n");
                }
            }
        }
        public static void LoadTasks()
        {
            if (File.Exists(path))
            {
                string[] line = File.ReadAllLines(path);
                foreach (string item in line)
                {
                    string props = item;
                    string[] props1 = props.Split(';');
                    var desc = props1[0];
                    var start = props1[1];
                    var end = props1[2];
                    bool allDay = false;
                    if (props1[3] == "false")
                    {
                        allDay = false;
                    }
                    else
                    {
                        allDay = true;
                    };
                    bool important = false;
                    if (props1[4] == "false")
                    {
                        important = false;
                    }
                    else
                    {
                        important = true;
                    };
                    TasksList.taskList.Add(new TaskModel1(desc, start, end, allDay, important));
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
