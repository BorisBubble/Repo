using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth.CellStuff
{
     public class Well : BaseCell
    {
        public Well(int x, int y) : base(x, y, 'U')
        {

        }

        public override bool TryToStep(Maze maze)
        {
            return true ;
        }
    }
}
