using ConsoleApp1.Objects.Labyrinth;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using ConsoleApp1.Objects.Labyrinth.CellStuff;
using System.Linq;

namespace ConsoleApp1
{
    public class Maze
    {
        public int Width;
        public int Height;
        public Hero Hero { get; set; }
        /// <summary>
        /// Ячейки с ландшафом
        /// </summary>
        public List<BaseCell> Cells { get; set; }

        public List<BaseCell> CellsWithHero
        {
            get
            {
                var copyCells = Cells.Select(x => x).ToList();
                ReplaceCellByNewCell(copyCells,Hero);
                return copyCells;
            }
        }

        public Maze(int width, int height)
        {
            Width = width;
            Height = height;
            Cells = new List<BaseCell>();
        }

        public void ReplaceCellByGround(BaseCell oldCell)

        {
            var ground = new Ground(oldCell.X, oldCell.Y);
            ReplaceCellByNewCell(ground);
        }

        /// <summary>
        /// Заменяет ячейку в списке с ландшафтом [Cells]
        /// </summary>
        /// <param name="newCell"></param>
        public void ReplaceCellByNewCell(BaseCell newCell)
        {
            ReplaceCellByNewCell(Cells, newCell);
        }

        /// <summary>
        /// Заменяет ячейку в переданном списке
        /// </summary>
        /// <param name="list"></param>
        /// <param name="newCell"></param>
        public void ReplaceCellByNewCell(List<BaseCell> list, BaseCell newCell)
        {
            var oldCell = list.Single(cell => cell.X == newCell.X && cell.Y == newCell.Y);
            list.Remove(oldCell);
            list.Add(newCell); ;
        }

        internal void TryToMove(Direction dir)
        {
            BaseCell destanation;
            switch (dir)
            {
                case Direction.Up:
                    destanation = Cells.SingleOrDefault(cell=>cell.X == Hero.X && cell.Y == Hero.Y - 1);
                    break;
                case Direction.Down:
                    destanation = Cells.SingleOrDefault(cell => cell.X == Hero.X && cell.Y == Hero.Y + 1);
                    break;
                case Direction.Left:
                    destanation = Cells.SingleOrDefault(cell => cell.X == Hero.X - 1 && cell.Y == Hero.Y);
                    break;
                case Direction.Right:
                    destanation = Cells.SingleOrDefault(cell => cell.X == Hero.X + 1 && cell.Y == Hero.Y);
                    break;
                default:
                    destanation = null;
                    break;
            }
            
            if (destanation?.TryToStep(this) ?? false)
            {
                Hero.Y = destanation.Y;
                Hero.X = destanation.X;
            }

        }

    }
}