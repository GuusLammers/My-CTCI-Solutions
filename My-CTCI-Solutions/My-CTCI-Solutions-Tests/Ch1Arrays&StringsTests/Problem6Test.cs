using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem6Test
    {
        [TestMethod]
        public void StringCompressionTest1Compressed()
        {
            // arrange
            String str = "aabcccccaaa";
            String expected = "a2b1c5a3";

            // act
            String actual = Problem6.StringCompression(str);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringCompressionTest2NotCompressed()
        {
            // arrange
            String str = "abca";
            String expected = "abca";

            // act
            String actual = Problem6.StringCompression(str);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringCompressionTest3Empty()
        {
            // arrange
            String str = "";
            String expected = "";

            // act
            String actual = Problem6.StringCompression(str);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

