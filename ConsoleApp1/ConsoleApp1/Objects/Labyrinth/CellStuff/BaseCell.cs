using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth
{
    public abstract class BaseCell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Symbol { get; private set; }

        public BaseCell(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public abstract bool TryToStep(Maze maze);
    }
}
