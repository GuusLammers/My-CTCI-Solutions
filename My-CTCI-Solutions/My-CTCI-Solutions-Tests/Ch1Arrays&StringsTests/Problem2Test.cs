using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        public void ArePermutationsTest1True()
        {
            // arrange
            String str1 = "hello";
            String str2 = "ollhe";
            bool expected = true;

            // act
            bool actual = Problem2.ArePermutations(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArePermutationsTest2False()
        {
            // arrange
            String str1 = "hello";
            String str2 = "hell";
            bool expected = false;

            // act
            bool actual = Problem2.ArePermutations(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArePermutationsTest3EmptyStrings()
        {
            // arrange
            String str1 = "";
            String str2 = "";
            bool expected = true;

            // act
            bool actual = Problem2.ArePermutations(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

