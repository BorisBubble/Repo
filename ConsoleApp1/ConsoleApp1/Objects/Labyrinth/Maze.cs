using ConsoleApp1.Objects.Labyrinth;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Maze
    {
        public int Width;
        public int Height;

        public List<Cell> Cells;

        public Maze(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new List<Cell>();
        }
    }
}
