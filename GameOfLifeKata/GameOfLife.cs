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
                                newGrid[i, j] = 1;
                            else
                                newGrid[i, j] = 0;
                        }            
                    }
                    else
                    {
                        newGrid[i, j] = grid[i, j];
                    }
                    
            return newGrid;
        }

        private static Boolean IsTopRightCorner(Int32 max, Int32 i, Int32 j)
        {
            return j == max && i == 0;
        }
    }
}
