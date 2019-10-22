using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public class Display : TasksList
    {
        public static void ShowTasks()
        {
            Console.WriteLine();
            string header = "Lp,Description,Start date,End date,All day, Important task";
            string[] sb = header.Split(',');
            Console.WriteLine($"{sb[0]} {sb[1].PadRight(20)}  {sb[2].PadRight(20)}  {sb[3].PadRight(20)}  {sb[4].PadRight(10)} {sb[5].PadRight(10)}");

            foreach (var item in TasksList.taskList)
            {
                Console.Write($"{taskList.IndexOf(item)}: {item.Description.PadRight(20)}; {item.DateStart.PadRight(20)}; {item.DateEnd.PadRight(20)}; {item.AllDayTask.ToString().PadRight(10)}; {item.ImportantTask.ToString().PadRight(10)}\n");
            }
            Console.WriteLine();
        }
    }
}
