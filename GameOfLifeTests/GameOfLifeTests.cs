using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //[Ignore]
        //[Test]
        //public void GridSizeShouldBePassedToMakeGrid()
        //{
        //    var actual = game.MakeGrid(3);
        //    Assert.That(actual, Is.EqualTo(new Int32[3, 3]));
        //}

        //[Ignore]
        //[Test]
        //public void MakeGridShouldReturnAGridWithAllSpacesFilledWithA0()
        //{
        //    var actual = game.MakeGrid(3);
        //    var expected = new Int32[3, 3];

        //    Assert.That(actual, Is.EqualTo(expected));
        //}

        //[Ignore]
        //[Test]
        //public void MakeGridShouldRandomlyFillTheGridWith1and0()
        //{
        //    var actual = game.MakeGrid(3);
        //    var shouldFail = false;

        //    foreach (var cell in actual)
        //        if (cell != 1 && cell != 0)
        //            shouldFail = true;

        //    Assert.That(shouldFail, Is.EqualTo(false));
        //}

        [Test]
        public void TopRightCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]{ { 0, 1, 0 },
                                     { 0, 1, 1 },
                                     { 0, 0, 0 } };

            var actual = game.MakeGrid(grid, 3);
            var expected = new Int32[,] { { 0, 1, 1 },
                                          { 0, 1, 1 },
                                          { 0, 0, 0 } };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TopLeftCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]{ { 0, 1, 0 },
                                     { 1, 1, 0 },
                                     { 0, 0, 0 } };

            var actual = game.MakeGrid(grid, 3);
            var expected = new Int32[,] { { 1, 1, 0 },
                                          { 1, 1, 0 },
                                          { 0, 0, 0 } };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BottomLeftCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]{ { 0, 0, 0 },
                                     { 1, 1, 0 },
                                     { 0, 1, 0 } };

            var actual = game.MakeGrid(grid, 3);
            var expected = new Int32[,] { { 0, 0, 0 },
                                          { 1, 1, 0 },
                                          { 1, 1, 0 } };

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void BottomRightCellWithExactly3NeightborsComesToLife()
        {
            var grid = new Int32[,]{ { 0, 0, 0 },
                                     { 0, 1, 1 },
                                     { 0, 1, 0 } };

            var actual = game.MakeGrid(grid, 3);
            var expected = new Int32[,] { { 0, 0, 0 },
                                          { 0, 1, 1 },
                                          { 0, 1, 1 } };

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
