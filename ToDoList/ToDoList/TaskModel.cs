using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.IO;

namespace ToDoList
{
    public class TaskModel
    {
        
        public string Description;
        public string DateStart;
        public string DateEnd;
        public bool AllDayTask;
        public bool ImportantTask;


        string path = @"result.txt";
        public string command = "";
        public List<string> taskHolder = new List<string>();
        public void AddTask()
        {
            Console.WriteLine("Enter task's description: ");
            Console.WriteLine("or type back to go to menu");
            do
            {
                command = Console.ReadLine();
                //dodawanie opisu
                string format = "dd.MM.yyyy hh:mm";
                DateTime DateStartTask;
                
                if (command.ToLower() != "back")
                {
                    Description = command;
                    taskHolder.Add(Description);

                    //dodawanie daty rozpoczęcia zadania
                    Console.WriteLine("Enter task's START date dd.MM. yyyy hh:mm: ");
                    DateStart = Console.ReadLine();


                    //if (DateTime.TryParse(yearMonthDay, out dateValue))

                    if (DateTime.TryParseExact(DateStart, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateStartTask))
                    {
                        Console.WriteLine($"Date's format correct\n{DateStartTask}");
                        taskHolder.Add(DateStart);
                        //return true;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect date's format");
                        //return false;
                    }
                    //czy zadanie jest jednodniowe
                    Console.WriteLine("Is the task a one day task? (y/n)");
                    string AllDayTask1 = Console.ReadLine();
                    string formatEndDate = "dd.MM.yyyy hh:mm";
                    //dodawanie daty zakończenia zadania
                    if (AllDayTask1 == "n")
                    {
                        Console.WriteLine("Enter task's END date dd.MM. yyyy hh:mm:: ");
                        formatEndDate = Console.ReadLine();
                        DateTime DateEnd;
                        formatEndDate = "dd.MM.yyyy hh:mm";
                        //if (DateTime.TryParse(yearMonthDay, out dateValue))
                        if (DateTime.TryParseExact(formatEndDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateEnd))
                        {
                            Console.WriteLine($"Date's format correct\n{DateEnd}");
                            //return true;
                        }
                        else
                        {
                            Console.WriteLine($"Incorrect date's format");
                            //return false;
                        }
                    }
                    else
                    {
                        AllDayTask = true;
                        Console.WriteLine("Your task has been flagged as One Day Task");
                        DateEnd?.ToString();
                        DateEnd = "One day task";
                       
                    }
                    //czy zadanie jest ważne
                    Console.WriteLine("Flag the task as important? (y/n)");
                    string importantTask = Console.ReadLine();
                    if (importantTask == "y")
                    {
                        ImportantTask = true;
                        Console.WriteLine("Your task has been flagged as Important");
                    }
                    else
                    {
                        ImportantTask = false;
                    }
                }
                foreach (var item in taskHolder)
                {
                    Console.Write($"{item},");
                }
                string dataHolder = $"{Description};{DateStart};{DateEnd}; Important task {ImportantTask}";
                Console.WriteLine("to add another task just type it's description\ntype back to go to menu");
                command = Console.ReadLine();
                
            }            
            while (command.ToLower() != "back");
        }
        public void ShowTasks()
        {
            foreach (object o in taskHolder );
        }

        public void Save()
        {
           
            if (File.Exists(path) == true)
            {
                //File.AppendAllLines(path, taskHolder.);
            }
            else
            {
                File.Create(path);
            }
        }
    }
}
/*do
            {
                Console.WriteLine("ToDoList");
                menu = Console.ReadLine();
                if (menu.ToLower() == "add")
                {
                    TaskModel task = new TaskModel();
                    task.AddTask();
                    mainTaskHolder.Add(task);
                }
                if (menu.ToLower() == "remove")
                {

                }
                if (menu.ToLower() == "show")
                {
                    
                }
                if (menu.ToLower() == "save")
                {
                    
                }
                if (menu.ToLower() == "load")
                {

                }
            }
            while (menu.ToLower() != "exit");*/
