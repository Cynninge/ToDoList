using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ToDoList
{
    public class Program
    {
        static void Main(string[] args)
        {           
            string menu = "";            
            while (menu.ToLower() != "exit")
            { 
                Console.WriteLine("<><><><><><><><><><><><><><><><><><><><>\nadd <[]> show <[]> save <[]> load <[]> remove <[]> clear <[]> exit\n<><><><><><><><><><><><><><><><><><><><>\n");
                Console.WriteLine("Command: ");                
                menu = Console.ReadLine();                
                switch (menu.ToLower())
                {
                    case "add":
                        Add.AddTask();                        
                        break;
                    case "remove":                        
                        Remove.RemoveRecord();
                        break;
                    case "save":
                        SaveLoad.SaveTasks();
                        break;
                    case "load":
                        SaveLoad.LoadTasks();
                        break;
                    case "show":
                        Display.ShowTasks();
                        break;
                    case "clear":
                        Clear.ClearMethod();
                        break;
                };                
            }  
        }  
    }
}
 
