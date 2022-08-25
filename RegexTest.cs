using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestAssignment;

namespace MSTest
{
    [TestClass]
    public class RegexTest
    {
        [TestMethod]
        public void TestingFirstName()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validateFirstName("Milan");
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestingLastName()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validateLastName("Biranwar");
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestingEmail()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validateEmail("milanbiranwar@gmail.com");
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestingmobileNumber()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validateMobileNumber("919032654896");
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestingPassword()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validatePassword("milanbiranwar");
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestingPassword6()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validatePassword6("Milanbiranwar");
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestingPassword7()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validatePassword7("Milanbiranwar123");
            Assert.AreEqual(expected, val);
        }

        [TestMethod]
        public void TestingPassword8()
        {
            Patterns pattern = new Patterns();
            bool expected = true;
            bool val = pattern.validatePassword8("Milanbiranwar123@");
            Assert.AreEqual(expected, val);
        }
    }
}