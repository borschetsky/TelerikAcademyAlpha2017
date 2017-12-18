using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem02BitShiftMatrix
{
    class Program
    {
        static BigInteger sum = 0;

        static void Main(string[] args)
        {
            int rowCounts = int.Parse(Console.ReadLine());
            int colCounts = int.Parse(Console.ReadLine());
            int readingCoef = int.Parse(Console.ReadLine());
            int coeff = Math.Max(rowCounts, colCounts);
            int[] numberOfMoves = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            BigInteger[,] matrix = new BigInteger[rowCounts, colCounts];
            int targetRow;
            int targetCol;
            
            FillingTheMatrix(matrix);
            
            int currentCol = 0;
            int currentRow = matrix.GetLength(0) - 1;
            for (int i = 0; i < numberOfMoves.Length; i++)
            {
                int code = numberOfMoves[i];
                targetRow = code / coeff;
                targetCol = code % coeff;

                if (currentCol < targetCol)
                {
                    for (int col = currentCol; col <= targetCol; col++)
                    {
                        sum += matrix[currentRow, col]; ;
                        matrix[currentRow, col] = 0;
                    }
                    
                }
                else
                {
                    for (int col = currentCol; col >= targetCol; col--)
                    {
                        sum += matrix[currentRow, col];
                        matrix[currentRow, col] = 0;
                    }
                }
                currentCol = targetCol;
                if (currentRow < targetRow)
                {
                    for (int row = currentRow; row <= targetRow; row++)
                    {
                        sum += matrix[row, currentCol];
                        matrix[row, currentCol] = 0;
                    }
                }
                else
                {
                    for (int row = currentRow ; row >= targetRow; row--)
                    {
                        sum += matrix[row, currentCol];
                        matrix[row, currentCol] = 0;
                    }
                }
                currentRow = targetRow;
                
               

            }
            Console.WriteLine(sum);
            //Printing(matrix);

        }

        private static void Printing(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        private static void FillingTheMatrix(BigInteger[,] matrix)
        {
            BigInteger counter = 1;
            for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {

                BigInteger rowsCounter = counter; ;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rowsCounter;
                    rowsCounter += rowsCounter;

                }
                counter += counter;

            }
        }
    }
}
