using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem3Test
    {
        [TestMethod]
        public void URLifyTest1()
        {
            // arrange
            String str = "Mr John Smith    ";
            int length = 13;
            String expected = "Mr%20John%20Smith";

            // act
            String actual = Problem3.URLify(str, length);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void URLifyTest2EmptyString()
        {
            // arrange
            String str = "";
            int length = 10;
            String expected = "";

            // act
            String actual = Problem3.URLify(str, length);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

