using System;

namespace GameOfLifeKata
{
    public class GameOfLife
    {
        private static Int32[,] newGrid;

        public Int32[,] CheckGrid(Int32[,] grid, Int32 size)
        {
            var max = size - 1;
            newGrid = new Int32[size, size];

            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    var liveNeighbors = 0;                

                    if (LeftNeighborIsAlive(grid, x, y))
                        liveNeighbors++;
                    if (RightNeighborIsAlive(grid, max, x, y))
                        liveNeighbors++;
                    if (TopLeftNeightIsAlive(grid, x, y))
                        liveNeighbors++;
                    if (TopNeighborIsAlive(grid, x, y))
                        liveNeighbors++;
                    if (TopRightNeighborIsAlive(grid, max, x, y))
                        liveNeighbors++;
                    if (BottomLeftNeighborIsAlive(grid, max, x, y))
                        liveNeighbors++;
                    if (BottomNeighborIsAlive(grid, max, x, y))
                        liveNeighbors++;
                    if (BottomRightNeighborIsAlive(grid, max, x, y))
                        liveNeighbors++;

                    SetCellStatus(grid, x, y, liveNeighbors);
                }
            }

            return newGrid;
        }
        
        private static Boolean LeftNeighborIsAlive(Int32[,] grid, Int32 x, Int32 y)
        {
            return y != 0 && grid[x, y - 1] == 1;
        }
        
        private static Boolean RightNeighborIsAlive(Int32[,] grid, Int32 max, Int32 x, Int32 y)
        {
            return y != max && grid[x, y + 1] == 1;
        }
 
        private static Boolean TopLeftNeightIsAlive(Int32[,] grid, Int32 x, Int32 y)
        {
            return x != 0 && y != 0 && grid[x - 1, y - 1] == 1;
        }
 
        private static Boolean TopNeighborIsAlive(Int32[,] grid, Int32 x, Int32 y)
        {
            return x != 0 && grid[x - 1, y] == 1;
        }

        private static Boolean TopRightNeighborIsAlive(Int32[,] grid, Int32 max, Int32 x, Int32 y)
        {
            return x != 0 && y != max && grid[x - 1, y + 1] == 1;
        }

        private static Boolean BottomLeftNeighborIsAlive(Int32[,] grid, Int32 max, Int32 x, Int32 y)
        {
            return x != max && y != 0 && grid[x + 1, y - 1] == 1;
        }

        private static Boolean BottomNeighborIsAlive(Int32[,] grid, Int32 max, Int32 x, Int32 y)
        {
            return x != max && grid[x + 1, y] == 1;
        }

       private static Boolean BottomRightNeighborIsAlive(Int32[,] grid, Int32 max, Int32 x, Int32 y)
        {
            return x != max && y != max && grid[x + 1, y + 1] == 1;
        }

        private static void SetCellStatus(Int32[,] grid, Int32 x, Int32 y, Int32 liveNeighbors)
        {
            if (grid[x, y] == 1 && (liveNeighbors == 2 || liveNeighbors == 3))
                newGrid[x, y] = 1;
            else if (liveNeighbors == 3)
                newGrid[x, y] = 1;
            else
                newGrid[x, y] = 0;
        }
    }
}
