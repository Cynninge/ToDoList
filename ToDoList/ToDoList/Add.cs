using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ToDoList
{
    public class Add
    {
        public static void AddTask()
        {
            Console.WriteLine("Enter task's description: ");
            string desc = Console.ReadLine();

            //------------------------------------------------------------------------------------------------------------------------

            DateTime start;
            string startDate = "";
            do
            {
                Console.WriteLine("Enter task's START date(dd.mm.yyyy: ");
                startDate = Console.ReadLine();

            } while (!DateTime.TryParseExact(startDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out start));

            //------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Is the task an all day task?(y/n)");
            string endDate = Console.ReadLine();
            bool allDay = false;
            DateTime end;
            if (endDate == "n")
            {
                Console.WriteLine("Enter task's end date(dd.mm.yyyy: ");
                endDate = Console.ReadLine();
                end = DateTime.Now;

                if (!DateTime.TryParseExact(endDate, "dd.mm.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out end))
                {
                    Console.WriteLine("Date's format incorrect");
                    endDate = "";
                }
            }
            else
            {
                allDay = true;
                endDate = "All day task";
                end = start;
            }

            //------------------------------------------------------------------------------------------------------------------------

            bool important = false;
            Console.WriteLine("Is this important task?(y/n)");
            if (Console.ReadLine() == "y")
            {
                important = true;
            }
            Program.taskList.Add(new TaskModel1(desc, start, end, allDay, important));
            
        }
    }
}
