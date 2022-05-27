using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Drawer
    {
        public static void Draw(Maze maze)
        {
            for (int yFun = 0; yFun < maze.Height; yFun++)
            {
                Console.WriteLine();
                Console.Write($"{yFun}");
                for (int i = 0; i < maze.Width; i++)
                {
                    Console.Write("@");
                }
            }
        }
    }
}
