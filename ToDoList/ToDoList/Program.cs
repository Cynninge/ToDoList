using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ToDoList
{
    public class Program
    {
        public static List<TaskModel1> taskList = new List<TaskModel1>();
        
        static void Main(string[] args)
        {
            Console.WriteLine("<><><><><><><><><><>\nTo Do List\nadd = add new task\nshow = show all tasks\n<><><><><><><><><><>");
            string menu = Console.ReadLine();            
            while (menu != "exit")
            {
                Console.WriteLine("Command: ");
                menu = Console.ReadLine();
                switch (menu)
                {
                    case "add":
                        Add.AddTask();                        
                        break;
                    case "remove":
                        //metoda remove
                        break;
                    case "save":
                        //metoda addtask
                        break;
                    case "load":
                        //metoda remove
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
                Console.Write($"{item.Description};{item.DateStart};{item.DateEnd};{item.AllDayTask};{item.ImportantTask}");
            }
        }        
    }
}

