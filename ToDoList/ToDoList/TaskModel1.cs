using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ToDoList
{
    public class TaskModel1
    {        
        public string Description { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public bool AllDayTask { get; set; }
        public bool ImportantTask { get; set; }

        public TaskModel1(string description, DateTime start, DateTime end, bool isAllDay, bool important)
        {
            Description = description;
            DateStart = start;
            DateEnd = end;
            AllDayTask = isAllDay;
            ImportantTask = important;
        }        
    }
}   
