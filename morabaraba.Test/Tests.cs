using System;
using System.Linq;
using NUnit.Framework;

namespace morabaraba.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ABoardHas12XAnd12OCows()
        {
            Board b = new Board();
            int XCows = b.Cows(Cow.X).Count();
            int OCows = b.Cows(Cow.O).Count();
            Assert.That(XCows == 0);
            Assert.That(OCows == 0);
        }
    }
}
