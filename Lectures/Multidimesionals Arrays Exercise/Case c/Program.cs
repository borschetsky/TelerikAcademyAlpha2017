using System;
using System.IO;

namespace Streams
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            //Count of diagonals
            int couuntOfDiagonals = matrix.GetLength(0) + matrix.GetLength(1) - 1;
            int counter = 1;
            for (int i = 0; i < couuntOfDiagonals; i++)
            {
                if (i < matrix.GetLength(0))
                {
                    int row = i;
                    int col = 0;
                    for (int j = 0; j <= i; j++)
                    {
                        matrix[row, col] = counter;
                        col++;
                        row--;
                        counter++;
                    }
                }
                else
                {
                    int col = i - matrix.GetLength(1) + 1;
                    int row = matrix.GetLength(0) - 1;
                    for (int j = i; j < couuntOfDiagonals; j++)
                    {
                        matrix[row, col] = counter;
                        col++;
                        row--;
                        counter++;

                    }
                }

            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}