﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth.CellStuff
{
    public class Wall : BaseCell
    {
        //public int X;
        //public int Y;
        //public char Symbol;
        public Wall(int x, int y) : base(x, y,'#')
        {

        }

        public override bool TryToStep(Maze maze)
        {
            return false;
        }
    }
}
