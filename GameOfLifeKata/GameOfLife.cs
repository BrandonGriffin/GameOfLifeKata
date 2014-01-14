using System;

namespace GameOfLifeKata
{
    public class GameOfLife
    {
        private Int32[,] newGrid;
        private Int32[,] grid;
        private Int32 numberOfRows;
        private Int32 numberOfColumns;

        public GameOfLife(Int32[,] grid)
        {
            this.grid = grid;
        }

        public Int32[,] CheckGrid()
        {
            numberOfRows = grid.GetLength(0);
            numberOfColumns = grid.GetLength(1);

            newGrid = new Int32[numberOfColumns, numberOfRows];

            for (var x = 0; x < numberOfColumns; x++)
            {
                for (var y = 0; y < numberOfRows; y++)
                {
                    var liveNeighbors = 0;

                    if (LeftNeighborIsAlive(x, y))
                        liveNeighbors++;
                    if (RightNeighborIsAlive(x, y))
                        liveNeighbors++;
                    if (TopLeftNeightIsAlive(x, y))
                        liveNeighbors++;
                    if (TopNeighborIsAlive(x, y))
                        liveNeighbors++;
                    if (TopRightNeighborIsAlive(x, y))
                        liveNeighbors++;
                    if (BottomLeftNeighborIsAlive(x, y))
                        liveNeighbors++;
                    if (BottomNeighborIsAlive(x, y))
                        liveNeighbors++;
                    if (BottomRightNeighborIsAlive(x, y))
                        liveNeighbors++;

                    var value = grid[x, y];
                    newGrid[x, y] = GetCellValue(value, liveNeighbors);
                }
            }

            grid = newGrid;
            return grid;
        }

        private Boolean LeftNeighborIsAlive(Int32 x, Int32 y)
        {
            return y != 0 && grid[x, y - 1] == 1;
        }

        private Boolean RightNeighborIsAlive(Int32 x, Int32 y)
        {
            return y != numberOfRows - 1 && grid[x, y + 1] == 1;
        }

        private Boolean TopLeftNeightIsAlive(Int32 x, Int32 y)
        {
            return x != 0 && y != 0 && grid[x - 1, y - 1] == 1;
        }

        private Boolean TopNeighborIsAlive(Int32 x, Int32 y)
        {
            return x != 0 && grid[x - 1, y] == 1;
        }

        private Boolean TopRightNeighborIsAlive(Int32 x, Int32 y)
        {
            return x != 0 && y != numberOfRows - 1 && grid[x - 1, y + 1] == 1;
        }

        private Boolean BottomLeftNeighborIsAlive(Int32 x, Int32 y)
        {
            return x != numberOfColumns - 1 && y != 0 && grid[x + 1, y - 1] == 1;
        }

        private Boolean BottomNeighborIsAlive(Int32 x, Int32 y)
        {
            return x != numberOfColumns - 1 && grid[x + 1, y] == 1;
        }

        private Boolean BottomRightNeighborIsAlive(Int32 x, Int32 y)
        {
            return x != numberOfColumns - 1 && y != numberOfRows - 1 && grid[x + 1, y + 1] == 1;
        }

        private Int32 GetCellValue(Int32 value, Int32 liveNeighbors)
        {
            if (CellIsAlive(value) && (liveNeighbors == 2 || liveNeighbors == 3))
                return 1;
            else if (liveNeighbors == 3)
                return 1;
            else
                return 0;
        }

        private Boolean CellIsAlive(Int32 value)
        {
            return value == 1;
        }
    }
}
