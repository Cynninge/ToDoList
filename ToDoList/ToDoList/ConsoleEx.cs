using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList
{
    public static class ConsoleEx
    {
        public static void Write(string Red)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(Red);
            Console.ResetColor();
        }

        public static void WriteLine()
        {

        }
    }
}
