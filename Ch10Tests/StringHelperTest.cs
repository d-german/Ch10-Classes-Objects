using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ch10Examples;

namespace Ch10Tests
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void IsCapitalizedTest()
        {
            Assert.IsTrue("Hello".IsCapitalized());
            Assert.IsFalse("".IsCapitalized());
            Assert.IsFalse("hello".IsCapitalized());
            Assert.IsTrue(StringHelper.IsCapitalized("Perth"));
        }
    }
}
