using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem8Test
    {
        private bool AreNonJaggedArraysEqual(int[,] arr1, int[,] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            if (arr1.GetLength(0) != arr2.GetLength(0) && arr1.GetLength(1) != arr2.GetLength(1))
            {
                return false;
            }

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] != arr2[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestMethod]
        public void ZeroMatrixTest1Equal()
        {
            // arrange
            int[,] matrix = new int[4, 5] {
                {1, 2, 3, 4, 5},
                {5, 0, 3, 2, 1},
                {4, 5, 1, 2, 3},
                {3, 4, 5, 1, 0}};
            int[,] expected = new int[4, 5] {
                {1, 0, 3, 4, 0},
                {0, 0, 0, 0, 0},
                {4, 0, 1, 2, 0},
                {0, 0, 0, 0, 0}};

            // act
            int[,] actual = Problem8.ZeroMatrix(matrix);

            // assert
            Assert.AreEqual(true, AreNonJaggedArraysEqual(actual, expected));
        }

        [TestMethod]
        public void ZeroMatrixTest2NotEqual()
        {
            // arrange
            int[,] matrix = new int[4, 5] {
                {1, 2, 3, 4, 5},
                {5, 0, 3, 2, 1},
                {4, 5, 1, 2, 3},
                {3, 4, 5, 1, 0}};
            int[,] expected = new int[4, 5] {
                {1, 0, 3, 4, 0},
                {0, 0, 0, 0, 0},
                {4, 0, 1, 2, 0},
                {3, 0, 5, 1, 0}};

            // act
            int[,] actual = Problem8.ZeroMatrix(matrix);

            // assert
            Assert.AreEqual(false, AreNonJaggedArraysEqual(actual, expected));
        }
    }
}

