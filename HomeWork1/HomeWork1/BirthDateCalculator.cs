using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    internal class BirthDateCalculator
    {
        public BirthDate BuildBirthDate()
        {

            int birthYear = ConsoleHelper.ReadInt("What year were you born?");
            Console.WriteLine($"Нour year of birth is {birthYear}, thank you.");

            int birthMonth = ConsoleHelper.ReadInt("What month were you born?");
            Console.WriteLine($"Нour year of birth is {birthMonth}, thank you.");

            int birthDay = ConsoleHelper.ReadInt("What day were you born?");
            Console.WriteLine($"Нour year of birth is {birthDay}, thank you.");



            //Console.WriteLine("What year were you born?");
            //string birthYear = Console.ReadLine();
            //Console.WriteLine($"Нour year of birth is {birthYear}, thank you.");

            //Console.WriteLine("What month were you born?");
            //string birthMonth = Console.ReadLine();
            //Console.WriteLine($"Нour year of birth is {birthMonth}, thank you.");

            //Console.WriteLine("What day were you born?");
            //string birthDay = Console.ReadLine();
            //Console.WriteLine($"Нour year of birth is {birthDay}, thank you.");

            //int birthYear = ConsoleHelper.ReadInt("How are old you?");

            //if (age < 20)
            //{
            //    Console.WriteLine("To yong");
            //    return null;
            //}
            //Console.WriteLine("Glad to see you");
            var birthDate = new BirthDate(birthDay, birthMonth, birthYear);
            return birthDate;
        }
    }
}
