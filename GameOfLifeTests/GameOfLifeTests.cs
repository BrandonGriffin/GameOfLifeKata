using System;
using NUnit.Framework;

namespace GameOfLifeKata.Tests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        private GameOfLife game;

        [SetUp]
        public void SetUp()
        {
            game = new GameOfLife();
        }

        [Test]
        public void TopRightCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,] 
            { 
                { 0, 1, 0 },
                { 0, 1, 1 },
                { 0, 0, 0 } 
            };

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 3);
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

            var actual = game.CheckGrid(grid, 5);
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
    }
}
