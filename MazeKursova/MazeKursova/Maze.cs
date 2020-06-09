using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace Maze_kursova
{

    class Maze
    {
        public readonly Cell[,] _cells;
        private int _width;
        private int _height;
        public Stack<Cell> _path = new Stack<Cell>();
        public List<Cell> _neighbours = new List<Cell>();
        public Random rnd = new Random();
        public Cell start;
        public Cell finish;
        public Maze(int width, int height)
        {
            start = new Cell(1, 1, true, true);
            finish = new Cell(width - 3, height - 3, true, true);
            _width = width;
            _height = height;
            _cells = new Cell[width, height];
            for (var i = 0; i < width; i++)
            {
                for (var j = 0; j < height; j++)
                {
                    if ((i % 2 != 0 && j % 2 != 0) && (i < _width - 1 && j < _height - 1)) 
                    {
                        _cells[i, j] = new Cell(i, j); 
                    }
                    else
                    {
                        _cells[i, j] = new Cell(i, j, false, false);
                    }
                }
            }
            _path.Push(start);
            
        }


        public void CreateMaze()
        {
            
            while (_path.Count != 0) 
            {
                _neighbours.Clear();
                GetNeighbours(_path.Peek());
                if (_neighbours.Count != 0)
                {
                    Cell nextCell = ChooseNeighbour(_neighbours);
                    RemoveWall(_path.Peek(), nextCell);
                    nextCell._isVisited = true; 
                    _cells[nextCell.X, nextCell.Y]._isVisited = true; 
                    _path.Push(nextCell);

                }
                else
                {
                    _path.Pop();
                }

            }
        }

        private void GetNeighbours(Cell localcell)
        {

            int x = localcell.X;
            int y = localcell.Y;
            const int distance = 2;
            Cell[] possibleNeighbours = new[] 
            {
                new Cell(x, y - distance), // Up
                new Cell(x + distance, y), // Right
                new Cell(x, y + distance), // Down
                new Cell(x - distance, y) // Left
            };
            for (int i = 0; i < 4; i++) 
            {
                Cell curNeighbour = possibleNeighbours[i];
                if (curNeighbour.X > 0 && curNeighbour.X < _width && curNeighbour.Y > 0 && curNeighbour.Y < _height)
                {
                    if (_cells[curNeighbour.X, curNeighbour.Y]._isCell && !_cells[curNeighbour.X, curNeighbour.Y]._isVisited)
                    {
                        _neighbours.Add(curNeighbour);
                    }
                }
            }

        }

        private Cell ChooseNeighbour(List<Cell> neighbours)
        {

            int r = rnd.Next(neighbours.Count);
            return neighbours[r];

        }

        private void RemoveWall(Cell first, Cell second)
        {
            int xDiff = second.X - first.X;
            int yDiff = second.Y - first.Y;
            int addX = (xDiff != 0) ? xDiff / Math.Abs(xDiff) : 0; // Наппрям видалення стіни
            int addY = (yDiff != 0) ? yDiff / Math.Abs(yDiff) : 0;

            // Координати видаленої стіни
            _cells[first.X + addX, first.Y + addY]._isCell = true; //обращаем стену в клетку
            _cells[first.X + addX, first.Y + addY]._isVisited = true; //клітинка відвідана 
            second._isVisited = true; //делаем клетку посещенной
            _cells[second.X, second.Y] = second;

        }
    }
}
