using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08BishopPathFinder
{
    class Program
    {
        static int[] rows = { -1, -1, 1, 1 };
        static int[] cols = { -1, 1, 1, -1 };

        static int GetMoveDirection(string dir)
        {
            switch (dir)
            {
                case "LU": return 0;
                case "UL": return 0;
                case "RU": return 0;
                case "UR": return 1;
                case "DR": return 2;
                case "RD": return 2;
                case "DL": return 3;
                case "LD": return 3;
                default:
                    throw new ArgumentException();
                    
            }
            
        }

        static void Main(string[] args)
        {
            int[] arrNum = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = arrNum[0];
            int cols = arrNum[1];

            var matrix = new int[rows, cols];
            //Filling
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;  j < cols;  j++)
                {
                    matrix[i, j] = (rows - 1 - i) * 3 + j * 3;
                }
            }
            int movesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < movesCount; i++)
            {
                var input = Console.ReadLine().Split();
                var dir = input[0];
                var repeat = int.Parse(input[1]);

            }
            PrintMatrix(matrix);
        }

        static void PrintMatrix (int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLongLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
