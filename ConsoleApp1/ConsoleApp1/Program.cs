using ConsoleApp1.Objects;
using ConsoleApp1.Objects.Labyrinth;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var userManager = new UserManager();
            var user = userManager.BuildUser();
            if (user == null)
            {
                return;
            }

            int width = ConsoleHelper.ReadInt($"Enter width maze {user.FullName()}");
            int height = ConsoleHelper.ReadInt($"Enter height maze {user.FullName()}");

            var generator = new MazeGenerator();
            var maze = generator.Generate(width, height);
            userManager.GoMaze(maze);
            }
        }
    }

