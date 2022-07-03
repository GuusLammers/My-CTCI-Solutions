using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions_Tests.Ch1ArraysStringsTests
{
    [TestClass]
    public class Problem7Test
    {
        private bool AreNonJaggedArraysEqual(int[,] arr1, int[,] arr2)
        {
            if(arr1.Length != arr2.Length)
            {
                return false;
            }

            if(arr1.GetLength(0) != arr2.GetLength(0) && arr1.GetLength(1) != arr2.GetLength(1))
            {
                return false;
            }

            for(int i = 0; i < arr1.GetLength(0); i++)
            {
                for(int j = 0; j < arr1.GetLength(1); j++)
                {
                    if(arr1[i, j] != arr2[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        [TestMethod]
        public void RotateMatrix90ClockwiseTest15x5()
        {
            // arrange
            int[,] image = new int[5, 5] {
                {1, 2, 3, 4, 5},
                {5, 4, 3, 2, 1},
                {4, 5, 1, 2, 3},
                {3, 4, 5, 1, 2},
                {5, 1, 2, 3, 4}};
            int[,] expected = new int[5, 5] {
                {5, 3, 4, 5, 1},
                {1, 4, 5, 4, 2},
                {2, 5, 1, 3, 3},
                {3, 1, 2, 2, 4},
                {4, 2, 3, 1, 5}}; ;

            // act
            Problem7.RotateMatrix90Clockwise(ref image);

            // assert
            Assert.AreEqual(true, AreNonJaggedArraysEqual(image, expected));
        }

        [TestMethod]
        public void RotateMatrix90ClockwiseTest24x4()
        {
            // arrange
            int[,] image = new int[4, 4] {
                {1, 2, 3, 4},
                {5, 4, 3, 2},
                {4, 5, 1, 2},
                {3, 4, 5, 1}};
            int[,] expected = new int[4, 4] {
                {3, 4, 5, 1},
                {4, 5, 4, 2},
                {5, 1, 3, 3},
                {1, 2, 2, 4}};

            // act
            Problem7.RotateMatrix90Clockwise(ref image);

            // assert
            Assert.AreEqual(true, AreNonJaggedArraysEqual(image, expected));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RotateMatrix90ClockwiseTest3Exception()
        {
            // arrange
            int[,] image = new int[5, 4] {
                {1, 2, 3, 4},
                {5, 4, 3, 2},
                {4, 5, 1, 2},
                {3, 4, 5, 1},
                {3, 4, 5, 1}};

            // act
            Problem7.RotateMatrix90Clockwise(ref image);
        }
    }
}

