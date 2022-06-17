using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth.CellStuff
{
    public class Hero : BaseCell

    {
        public int Gold { get; set; }
        public Hero(int x, int y) : base(x, y, '@')
        {
        }

        public override bool TryToStep(Maze maze)
        {
            return false;
        }
    }
}
