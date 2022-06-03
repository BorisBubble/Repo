using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; private set; }

        public Cell(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }
    }
}
