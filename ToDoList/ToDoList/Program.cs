using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ToDoList
{
    public class Program
    {
        public static List<TaskModel1> taskList = new List<TaskModel1>();
        public static string path = @"tasks.txt";
        
        static void Main(string[] args)
        {           
            string menu = "";            
            while (menu != "exit")
            {
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>\nadd <[]> show <[]> save <[]> load <[]> remove <[]> exit\n<><><><><><><><><><><><><><><><><><><><>");
                Console.WriteLine("Command: ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "add":
                        Add.AddTask();                        
                        break;
                    case "remove":                        
                        Remove.RemoveRecord();
                        break;
                    case "save":
                        Program.SaveTasks();
                        break;
                    case "load":
                        Program.LoadTasks();
                        break;
                    case "show":
                        Program.ShowTasks();
                        break;                   
                };
            }  
        }

        public static void ShowTasks()
        {
            foreach (var item in taskList)
            {                
                Console.Write($"{taskList.IndexOf(item)}: {item.Description};{item.DateStart};{item.DateEnd};{item.AllDayTask};{item.ImportantTask}\n");                
            }
        }

        public static void SaveTasks()
        {
            string save = "";  
            if (File.Exists(path))
            {
                foreach (var item in taskList)
                {
                    save += $"{item.Description};{item.DateStart};{item.DateEnd};{item.AllDayTask};{item.ImportantTask}\n";
                }
                File.WriteAllText(path, save);
            }
            else
            {
                File.Create(path);
                foreach (var item in taskList)
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
                    Program.taskList.Add(new TaskModel1(desc, start, end, allDay, important));
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
 
