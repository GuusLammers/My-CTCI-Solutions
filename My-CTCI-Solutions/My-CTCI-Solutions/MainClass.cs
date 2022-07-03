using My_CTCI_Solutions.Ch1ArraysStrings;

namespace My_CTCI_Solutions
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            int[,] image = new int[4, 5] {
                {1, 2, 3, 4, 5},
                {5, 0, 3, 2, 1},
                {4, 5, 1, 2, 3},
                {3, 4, 5, 1, 0}};


            int[,] alteredMatrix = Problem8.ZeroMatrix(image);

            for(int i = 0; i < alteredMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < alteredMatrix.GetLength(1); j++)
                {
                    Console.Write(alteredMatrix[i, j]);
                }

                Console.Write("\n");
            }
        }
    }
}


