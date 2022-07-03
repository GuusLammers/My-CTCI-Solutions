using System;
namespace My_CTCI_Solutions.Ch1ArraysStrings
{
    public class Problem8
    {
        // Write an algorithm such that if an element in an MxN matrix is 0, its entire row and
        // column are set to 0.

        public static int[,] ZeroMatrix(int[,] matrix)
        {
            int[,] alteredMatrix = (int[,])matrix.Clone();

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if(matrix[i, j] == 0)
                    {
                        // overwrite col
                        for(int z = 0; z < matrix.GetLength(0); z++)
                        {
                            alteredMatrix[z, j] = 0;
                        }

                        // overwrite row
                        for (int z = 0; z < matrix.GetLength(1); z++)
                        {
                            alteredMatrix[i, z] = 0;
                        }
                    }
                }
            }

            return alteredMatrix;
        }
    }
}

