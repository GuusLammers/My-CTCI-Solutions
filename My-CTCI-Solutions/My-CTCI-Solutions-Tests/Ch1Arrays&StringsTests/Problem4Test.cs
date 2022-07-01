using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem4Test
    {
        [TestMethod]
        public void IsPalindromeTest1True()
        {
            // arrange
            String str = "racecar";
            bool expected = true;

            // act
            bool actual = Problem4.IsPalindrome(str);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindromeTest2False()
        {
            // arrange
            String str = "raceca";
            bool expected = false;

            // act
            bool actual = Problem4.IsPalindrome(str);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindromeTest3Empty()
        {
            // arrange
            String str = "";
            bool expected = true;

            // act
            bool actual = Problem4.IsPalindrome(str);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromePermutationsTest1True()
        {
            // arrange
            String str = "Tact Coa";
            bool expected = true;

            // act
            bool actual = Problem4.PalindromePermutation(str);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromePermutationsTest2False()
        {
            // arrange
            String str = "Tact Co";
            bool expected = false;

            // act
            bool actual = Problem4.PalindromePermutation(str);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PalindromePermutationsTest3Empty()
        {
            // arrange
            String str = "";
            bool expected = true;

            // act
            bool actual = Problem4.PalindromePermutation(str);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

