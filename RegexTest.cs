using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestAssignment;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validateFirstName("Milan");
            Assert.AreEqual(expected, val);
        }
    }
}