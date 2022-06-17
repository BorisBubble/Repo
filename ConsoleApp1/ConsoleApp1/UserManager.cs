using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Objects.Labyrinth;

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


        public void GoMaze(Maze maze)
        {
            while (true)
            {
                Drawer.Draw(maze);
                var key = Console.ReadKey();
                Direction dir;
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine("Bye");
                        return;
                    case ConsoleKey.DownArrow:
                        dir = Direction.Down;
                        break;
                    case ConsoleKey.UpArrow:
                        dir = Direction.Up;
                        break;
                    case ConsoleKey.LeftArrow:
                        dir = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        dir = Direction.Right;
                        break;
                    default:
                        dir = Direction.Idle;
                        break;
                }

                maze.TryToMove(dir);
            }
        }
    }
}
