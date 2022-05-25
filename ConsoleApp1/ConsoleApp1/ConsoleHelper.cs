using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ConsoleHelper
    {
        public static int ReadInt(string message)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();
            return int.Parse(str);
        }
    }
}
