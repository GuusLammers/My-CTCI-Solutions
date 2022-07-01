using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem5Test
    {
        [TestMethod]
        public void OneEditTest1TrueRemove()
        {
            // arrange
            String str1 = "pale";
            String str2 = "ple";
            bool expected = true;

            // act
            bool actual = Problem5.OneEdit(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneEditTest2TrueInsert()
        {
            // arrange
            String str1 = "ple";
            String str2 = "pale";
            bool expected = true;

            // act
            bool actual = Problem5.OneEdit(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneEditTest3TrueReplace()
        {
            // arrange
            String str1 = "pale";
            String str2 = "bale";
            bool expected = true;

            // act
            bool actual = Problem5.OneEdit(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneEditTest4FalseDifferingLength()
        {
            // arrange
            String str1 = "pales";
            String str2 = "ple";
            bool expected = false;

            // act
            bool actual = Problem5.OneEdit(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneEditTest5FalseIdentical()
        {
            // arrange
            String str1 = "pale";
            String str2 = "pale";
            bool expected = false;

            // act
            bool actual = Problem5.OneEdit(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

