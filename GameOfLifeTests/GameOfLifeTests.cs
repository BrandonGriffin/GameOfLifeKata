using System;
using NUnit.Framework;

namespace GameOfLifeKata.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        [Test]
        public void TopRightCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,] 
            { 
                { 0, 1, 0 },
                { 0, 1, 1 },
                { 0, 0, 0 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            { 
                { 0, 1, 1 },
                { 0, 1, 1 },
                { 0, 0, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TopLeftCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]
            { 
                { 0, 1, 0 },
                { 1, 1, 0 },
                { 0, 0, 0 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            { 
                { 1, 1, 0 },
                { 1, 1, 0 },
                { 0, 0, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BottomLeftCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]
            { 
                { 0, 0, 0 },
                { 1, 1, 0 },
                { 0, 1, 0 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            { 
                { 0, 0, 0 },
                { 1, 1, 0 },
                { 1, 1, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BottomRightCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]
            { 
                { 0, 0, 0 },
                { 0, 1, 1 },
                { 0, 1, 0 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            { 
                { 0, 0, 0 },
                { 0, 1, 1 },
                { 0, 1, 1 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TopRowCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]
            { 
                { 0, 0, 1 },
                { 0, 1, 1 },
                { 0, 0, 0 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            { 
                { 0, 1, 1 },
                { 0, 1, 1 },
                { 0, 0, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void LeftSideCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]
            {
                { 0, 1, 0 },
                { 0, 1, 0 },
                { 1, 0, 0 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            {
                { 0, 0, 0 },
                { 1, 1, 0 },
                { 0, 0, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void RightSideCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]
            { 
                { 0, 1, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            {
                { 0, 0, 0 },
                { 0, 1, 1 },
                { 0, 0, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BottomRowCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]
            { 
                { 0, 0, 0 },
                { 1, 1, 0 },
                { 0, 0, 1 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            {
                { 0, 0, 0 },
                { 0, 1, 0 },
                { 0, 1, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CellWithExactlyTwoOrLessNeighborsDies()
        {
            var grid = new Int32[,]
            { 
                { 0, 0, 0 },
                { 1, 1, 0 },
                { 0, 0, 1 } 
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            { 
                { 0, 0, 0 },
                { 0, 1, 0 },
                { 0, 1, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }
        
        [Test]
        public void BiggerGridReturnsTheCorrectResult()
        {
            var grid = new Int32[,]
            { 
                { 0, 0, 0, 1, 0 },
                { 1, 1, 0, 1, 1 },
                { 0, 0, 1, 0, 0 },
                { 1, 1, 0, 0, 0 },
                { 0, 0, 1, 0, 0 }
            };

            var game = new GameOfLife(grid);
            var actual = game.CheckGrid();
            var expected = new Int32[,] 
            { 
                { 0, 0, 1, 1, 1 },
                { 0, 1, 0, 1, 1 },
                { 0, 0, 1, 1, 0 },
                { 0, 1, 1, 0, 0 },
                { 0, 1, 0, 0, 0 }
            };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TwoIterationsOfAGridReturnsTheCorrectResult()
        {
            var grid = new Int32[,]
            { 
                { 0, 0, 0 },
                { 1, 1, 0 },
                { 0, 0, 1 } 
            };

            var game = new GameOfLife(grid);
            var firstRun = game.CheckGrid();
            var actual = game.CheckGrid();

            var expected = new Int32[,] 
            { 
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 } 
            };

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
