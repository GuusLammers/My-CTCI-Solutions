using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem1Test
    {
        [TestMethod]
        public void IsUniqueTest1Unique()
        {
            // arrange
            String str = "abcdefghijklmnopqrstuvwxyz";
            bool expected = true;

            // act
            bool output = Problem1.IsUnique(str);

            // assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void IsUniqueTest2NotUnique()
        {
            // arrange
            String str = "aaabcdefghijklmnopqrstuvwxyz";
            bool expected = false;

            // act
            bool output = Problem1.IsUnique(str);

            // assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void IsUniqueInplaceTest1Unique()
        {
            // arrange
            String str = "abcdefghijklmnopqrstuvwxyz";
            bool expected = true;

            // act
            bool output = Problem1.IsUniqueInPlace(str);

            // assert
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void IsUniqueInplaceTest2NotUnique()
        {
            // arrange
            String str = "abcdefghijklmnopqrstuvwxyza";
            bool expected = false;

            // act
            bool output = Problem1.IsUniqueInPlace(str);

            // assert
            Assert.AreEqual(expected, output);
        }
    }
}

