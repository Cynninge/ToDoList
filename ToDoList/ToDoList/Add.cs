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
                Console.WriteLine("Enter task's START date(MM/dd/yyyy HH:mm): ");
                startDate = Console.ReadLine();

            } while (!DateTime.TryParseExact(startDate, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out start));

            //------------------------------------------------------------------------------------------------------------------------

            Console.WriteLine("Is the task an all day task?(y/n)");
            string endDate = Console.ReadLine();
            bool allDay = false;
            DateTime end;
            if (endDate == "n")
            {
                Console.WriteLine("Enter task's end date(MM/dd/yyyy HH:mm): ");
                endDate = Console.ReadLine();
                end = DateTime.Now;

                if (!DateTime.TryParseExact(endDate, "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out end) ||
                    start.Date > end.Date)
                {
                    Console.WriteLine("Date's format incorrect or end date is before start date (Time Machine is premium option ;) )");
                    endDate = "";
                    return;
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

            TasksList.taskList.Add(new TaskModel1(desc, startDate, endDate, allDay, important));            
        }
    }
}
