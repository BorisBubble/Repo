using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth.CellStuff
{
    internal class Ground : BaseCell
    {
        public Ground(int x, int y) : base(x, y, '.')
        {
            
        }

        public override bool TryToStep(Maze maze)
        {
            return true;
        }
    }
}
