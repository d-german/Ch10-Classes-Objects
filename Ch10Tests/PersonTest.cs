using Ch10Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch10Tests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void PersonConstructorTest()
        {
            var p1 = new Person();
            var p2 = new Person("Mary", "Jane");
            Assert.AreEqual(2, Person.Count);
        }
    }
}