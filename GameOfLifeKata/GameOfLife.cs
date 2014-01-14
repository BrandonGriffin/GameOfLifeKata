using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeKata
{
    public class GameOfLife
    {
        public Int32[,] MakeGrid(Int32[,] grid, Int32 size)
        {
            var max = size - 1;
            var newGrid = new Int32[3, 3];

            for (var i = 0; i < size; i++)
                for (var j = 0; j < size; j++)
                    if (grid[i, j] == 0)
                    {
                        if (IsTopRightCorner(max, i, j))
                        {
                            if (grid[i, j - 1] == 1 && grid[i + 1, j - 1] == 1 && grid[i + 1, j] == 1)
                                BringCellToLife(newGrid, i, j);
                            else
                                KillCell(newGrid, i, j);
                        }
                        else if (IsTopLeftCorner(i, j))
                        {
                            if (grid[i, j + 1] == 1 && grid[i + 1, j + 1] == 1 && grid[i + 1, j] == 1)
                                BringCellToLife(newGrid, i, j);
                            else
                                KillCell(newGrid, i, j);
                        }
                        else if (IsBottomLeftCorner(max, i, j))
                        {
                            if (grid[i, j + 1] == 1 && grid[i - 1, j + 1] == 1 && grid[i - 1, j] == 1)
                                BringCellToLife(newGrid, i, j);
                            else
                                KillCell(newGrid, i, j);
                        }
                        else if (IsBottomRightCorner(max, i, j))
                        {
                            if (grid[i - 1, j - 1] == 1 && grid[i - 1, j] == 1 && grid[i, j - 1] == 1)
                                BringCellToLife(newGrid, i, j);
                            else
                                KillCell(newGrid, i, j);
                        }
                        else if (IsTopRow(i))
                        {
                            var liveNeighbors = 0;
                            
                            if (grid[i, j - 1] == 1)
                                liveNeighbors++;
                            if (grid[i, j + 1] == 1)
                                liveNeighbors++;
                            if (grid[i + 1, j - 1] == 1)
                                liveNeighbors++;
                            if (grid[i + 1, j] == 1)
                                liveNeighbors++;
                            if (grid[i + 1, j + 1] == 1)
                                liveNeighbors++;

                            if (liveNeighbors == 3)
                                BringCellToLife(newGrid, i, j);
                            else
                                KillCell(newGrid, i, j);
                        }
                        else if (IsLeftSide(j))
                        {
                            var liveNeighbors = 0;

                            if (grid[i, j + 1] == 1)
                                liveNeighbors++;
                            if (grid[i + 1, j + 1] == 1)
                                liveNeighbors++;
                            if (grid[i - 1, j + 1] == 1)
                                liveNeighbors++;
                            if (grid[i + 1, j] == 1)
                                liveNeighbors++;
                            if (grid[i - 1, j] == 1)
                                liveNeighbors++;

                            if (liveNeighbors == 3)
                                BringCellToLife(newGrid, i, j);
                            else
                                KillCell(newGrid, i, j);
                        }
                        else if (IsRightSide(max, j))
                        {
                            var liveNeighbors = 0;

                            if (grid[i, j - 1] == 1)
                                liveNeighbors++;
                            if (grid[i + 1, j - 1] == 1)
                                liveNeighbors++;
                            if (grid[i - 1, j - 1] == 1)
                                liveNeighbors++;
                            if (grid[i + 1, j] == 1)
                                liveNeighbors++;
                            if (grid[i - 1, j] == 1)
                                liveNeighbors++;

                            if (liveNeighbors == 3)
                                BringCellToLife(newGrid, i, j);
                            else
                                KillCell(newGrid, i, j);
                        }
                    }
                    else
                    {
                        newGrid[i, j] = grid[i, j];
                    }
                    
            return newGrid;
        }

        private static Boolean IsTopRow(Int32 i)
        {
            return i == 0;
        }

        private static Boolean IsLeftSide(Int32 j)
        {
            return j == 0;
        }

        private static Boolean IsRightSide(Int32 max, Int32 j)
        {
            return j == max;
        }

        private static Int32 KillCell(Int32[,] newGrid, Int32 i, Int32 j)
        {
            return newGrid[i, j] = 0;
        }

        private static Int32 BringCellToLife(Int32[,] newGrid, Int32 i, Int32 j)
        {
            return newGrid[i, j] = 1;
        }

        private static Boolean IsTopRightCorner(Int32 max, Int32 i, Int32 j)
        {
            return j == max && i == 0;
        }

        private static Boolean IsTopLeftCorner(Int32 i, Int32 j)
        {
            return i == 0 && j == 0;
        }

        private static Boolean IsBottomLeftCorner(Int32 max, Int32 i, Int32 j)
        {
            return i == max && j == 0;
        }

        private static Boolean IsBottomRightCorner(Int32 max, Int32 i, Int32 j)
        {
            return i == max && j == max;
        }
    }
}
