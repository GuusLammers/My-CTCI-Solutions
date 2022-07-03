using System;
namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem7
    {
        // Given an image represented by an NxN matrix, where each pixel in the image is 4
        // bytes, write a method to rotate the image by 90 degrees.Can you do this in place?

        public static void RotateMatrix90Clockwise(ref int[,] image)
        {
            if (image.GetLength(0) != image.GetLength(1))
            {
                throw new ArgumentException("Array must be square.");
            }

            for (int i = 0; i < image.GetLength(0) / 2; i++)
            {
                for (int j = i; j < image.GetLength(0) - i - 1; j++)
                {
                    // store top left cell in a temporary variable.
                    int temporary = image[i, j];

                    // move value from left to top.
                    image[i, j] = image[image.GetLength(0) - j - 1, i];

                    // move elements from bottom to left.
                    image[image.GetLength(0) - j - 1, i] = image[image.GetLength(0) - i - 1, image.GetLength(0) - j - 1];

                    // move elements from right to bottom.
                    image[image.GetLength(0) - i - 1, image.GetLength(0) - j - 1] = image[j, image.GetLength(0) - i - 1];

                    // move elements from top to right.
                    image[j, image.GetLength(0) - i - 1] = temporary;
                }
            }
        }


        ///[1,1,1,1,1
        /// 2,2,2,2,2
        /// 3,3,3,3,3
        /// 4,4,4,4,4
        /// 5,5,5,5,5]

        ///[5,4,3,2,1
        /// 5,4,3,2,1
        /// 5,4,3,2,1
        /// 5,4,3,2,1
        /// 5,4,3,2,1]
    }
}

