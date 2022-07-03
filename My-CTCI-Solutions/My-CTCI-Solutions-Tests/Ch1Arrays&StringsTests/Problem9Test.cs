using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem9Test
    {
        [TestMethod]
        public void IsRotationTest1True()
        {
            // arrange
            String str1 = "waterbottle";
            String str2 = "erbottlewat";
            bool expected = true;

            // act
            bool actual = Problem9.StringRotation(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRotationTest2False()
        {
            // arrange
            String str1 = "waterbottle";
            String str2 = "ttewaterbot";
            bool expected = false;

            // act
            bool actual = Problem9.StringRotation(str1, str2);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}

