using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class UserManager
    {
        public User BuildUser()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi, {name} glad to see you.");

            int age = ConsoleHelper.ReadInt("How are old you?");

            if (age < 20)
            {
                Console.WriteLine("To yong");
                return null;
            }
            Console.WriteLine("Glad to see you");
            var user = new User(name, age);
            return user;
        }
    }
}
