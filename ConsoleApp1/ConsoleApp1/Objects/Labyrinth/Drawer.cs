using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Drawer
    {
        public static void Draw(Maze maze)
        {
            Console.Clear();
            Console.WriteLine($"Hero has {maze.Hero.Gold} coins");
            for (int y = 0; y < maze.Height; y++)
            {
                Console.WriteLine();
                Console.Write($"{y}");
                for (int x = 0; x < maze.Width; x++)
                {
                    var cell = maze.CellsWithHero.Single(cell => cell.X == x && cell.Y == y);
                    Console.Write(cell.Symbol);
                }
            }
        }
    }
}
