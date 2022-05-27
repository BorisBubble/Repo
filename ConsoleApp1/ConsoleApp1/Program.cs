using ConsoleApp1.Objects;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            
            var userManager = new userManager();
            var user =  userManager.BuildUser();

           
            int width = ConsoleHelper.ReadInt($"Enter width maze {user.FullName()}");
            int height = ConsoleHelper.ReadInt($"Enter height maze {user.FullName()}");

            var maze = new Maze(width, height);
            Drawer.Draw(maze);

        }


    }
}
