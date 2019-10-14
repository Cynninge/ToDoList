using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ToDoList
{
    public class TaskModel1
    {        
        public string Description { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public bool AllDayTask { get; set; }
        public bool ImportantTask { get; set; }
        

        public TaskModel1(string description, string start, string end, bool isAllDay, bool important)
        {
            Description = description;
            DateStart = start;
            DateEnd = end;
            AllDayTask = isAllDay;
            ImportantTask = important;            
        }        
    }
}   
