using System;
using Ch10Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch10Tests
{
    [TestClass]
    public class BoxTest
    {
        [TestMethod]
        public void TestAdditionOperator()
        {
            var box1 = new Box() { Length = 1, Height = 1, Width = 1 };
            var box2 = new Box() { Length = 3, Width = 4, Height = 5 };

            var actualBox = box1 + box2;
            var expectedBox = new Box() { Length = 4, Width = 5, Height = 6 };

            Assert.IsTrue(actualBox == expectedBox);
        }
    }
}
