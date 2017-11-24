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
            int sequenceOfSums = (sizeOfMatrix[0] - 2) * (sizeOfMatrix[1] - 2);
            Console.WriteLine(sequenceOfSums);
            //Filling the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(new string[] {" "}, 
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];

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
        
        }
    }
}
