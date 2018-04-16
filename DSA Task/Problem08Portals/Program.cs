using System;
using System.Linq;

namespace Problem08Portals
{
    class Program
    {
        static int maxResult;
        static int[,] matrix;
        static void Main(string[] args)
        {
            
            var startPoint = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            var matrixSize = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            
            int rows = matrixSize[0];
            int cols = matrixSize[1];
            matrix = new int[rows, cols];
            //Filling the matrix
            for (int row = 0; row < rows; row++)
            {
                string[] colValues = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    if (colValues[col] != "#")
                    {
                        matrix[row, col] = int.Parse(colValues[col]);
                    }
                    else
                    {
                        matrix[row, col] = -1;
                    }
                }
            }
            //printing the matrix
            //for (int i = 0; i < matrix.GetLongLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLongLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
                    
            //    }
            //    Console.WriteLine();
            //}
            DFS(startPoint[0], startPoint[1], 0, matrix);
            Console.WriteLine(maxResult);
        }

        public static void DFS(int row, int col, int power, int[,] matrix)
        {
            if (maxResult < power)
            {
                maxResult = power;
            }
            var currnetPower = matrix[row, col];
            if (currnetPower > 0)
            {
                var nextPower = power + currnetPower;

                //up
                var up = row - currnetPower;
                if (up >= 0 && matrix[up, col] != -1)
                {
                    matrix[row, col] = 0;
                    DFS(up, col, nextPower, matrix);
                    matrix[row, col] = currnetPower;
                }
                //down
                var down = row + currnetPower;
                if (down < matrix.GetLength(0) && matrix[down, col] != -1)
                {
                    matrix[row, col] = 0;
                    DFS(down, col, nextPower, matrix);
                    matrix[row, col] = currnetPower;
                }
                //left
                var left = col - currnetPower;
                if (left >=0 && matrix[row, left] != -1)
                {
                    matrix[row, col] = 0;
                    DFS(row, left, nextPower, matrix);
                    matrix[row, col] = currnetPower;
                }
                //right
                var right = col + currnetPower;
                if (right < matrix.GetLength(1) && matrix[row, right] != -1)
                {
                    matrix[row, col] = 0;
                    DFS(row, right, nextPower, matrix);
                    matrix[row, col] = currnetPower;
                }

            }
        }
    }
}
