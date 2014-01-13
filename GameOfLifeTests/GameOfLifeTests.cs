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
        [Test]
        public void GameShouldReturnAGrid()
        {
            var game = new GameOfLife();
            var actual = game.MakeGrid();

            Assert.That(actual, Is.EqualTo(new Int32[,]{}));
        }
    }
}
