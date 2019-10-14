using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public static class Remove
    {
        public static void RemoveRecord()
        {
            Program.ShowTasks();
            Console.WriteLine("Which task do you want to delete? (type it's index number)");
            string indexInput = Console.ReadLine();
            int indexRemove = 0;

            if (Int32.TryParse(indexInput, out indexRemove))
            {
                Program.taskList.RemoveAt(indexRemove);
            }
            else
            {
                Console.WriteLine("Wrong number or number is out of list's range.");
            };     
        }
    }
}
