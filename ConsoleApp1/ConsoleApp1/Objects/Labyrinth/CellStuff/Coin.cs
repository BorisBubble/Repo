using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth.CellStuff
{
    internal class Coin : BaseCell
    {
        public Coin(int x, int y) : base(x, y, 'c')
        {
        }

        public override bool TryToStep(Maze maze)
        {
            maze.Hero.Gold++;
            maze.ReplaceCellByGround(this);
            return true;
        }
    }
}
