using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02MaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];
            FillinTheMainMatrix(matrix);
            //
            int maximalSum = 0;

            //Summin 3x3 elemnts
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                int currentS = 0;
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                          currentS =  matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                }
                if (currentS > maximalSum)
                {
                    maximalSum = currentS;
                }
            }
            //Printing Matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(maximalSum);
          

        }

        private static void FillinTheMainMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(new string[] { " " },
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];

                }
            }
        }
    }
}
