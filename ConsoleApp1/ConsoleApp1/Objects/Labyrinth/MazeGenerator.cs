using ConsoleApp1.Objects.Labyrinth.CellStuff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Objects.Labyrinth
{
    internal class MazeGenerator
    {
        private Maze _maze;

        public Maze Generate(int width, int height)
        {
            _maze = new Maze(width, height);

            FillMazeWitWall();

            GenerateGrounds();

            GenerateCoin();

            GenerateDollar();

            return _maze;
        }
        private void GenerateDollar()
        {
            var c = _maze.Cells.Single(x => x.X == 0 && x.Y == 0);
            _maze.Cells.Remove(c);
            var dollar = new Dollar(c.X, c.Y);
            _maze.Cells.Add(dollar);
        }
        private void GenerateCoin()
        {
            var c = _maze.Cells.Single(x => x.X == _maze.Width - 1 && x.Y == 0);
            _maze.Cells.Remove(c);
            var well = new Well(c.X, c.Y);
            _maze.Cells.Add(well);
        }
        private void GenerateGrounds()
        {
            var workCell = _maze.Cells.First();
            var redWall = new List<Cell>();

            do
            {
                ReplaceCellByGround(workCell);
                var nearWall = GetNear(workCell, _maze).OfType<Wall>();
                redWall.AddRange(nearWall);
                redWall = RemoveWallToAvoidCycle(redWall);
                workCell = GetRandom(redWall);
                redWall.Remove(workCell);
            } while (redWall.Any());
        }
        private List<Cell> RemoveWallToAvoidCycle(List<Cell> cells)
        {
            return cells.Where(red =>
                    GetNear(red, _maze).OfType<Ground>().Count() <= 1)
                    .ToList();
    }
        private void ReplaceCellByGround(Cell cell)
        {
            _maze.Cells.Remove(cell);
            var ground = new Ground(cell.X, cell.Y);
            _maze.Cells.Add(ground);
        }
        private void FillMazeWitWall()
        {
            for (int y = 0; y < _maze.Height; y++)
            {
                for (int x = 0; x < _maze.Width; x++)
                {
                    var cell = new Wall(x, y);
                    _maze.Cells.Add(cell);
                }
            }
        }
        private List<Cell> GetNear(Cell targetCell, Maze maze)
        {
            return maze.Cells.Where(cell =>
                cell.X == targetCell.X && cell.Y == targetCell.Y - 1
                || cell.X == targetCell.X && cell.Y == targetCell.Y + 1
                || cell.X == targetCell.X - 1 && cell.Y == targetCell.Y
                || cell.X == targetCell.X + 1 && cell.Y == targetCell.Y)
                .ToList();
        }
        private Cell GetRandom(List<Cell> cells)
        {
            var random = new Random();
            var index = random.Next(cells.Count);
            return cells[index];
        }
        internal object Generate()
        {
            throw new NotImplementedException();
        }
    }
}
