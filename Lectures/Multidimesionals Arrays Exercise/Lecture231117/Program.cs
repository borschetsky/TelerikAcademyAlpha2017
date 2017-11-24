using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
           //Case a
            if (symbol == 'a')
            {
                int counter = 1;
                for (int col = 0; col < n; col++)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = counter;
                        counter++;
                    }
                }
                    
            }
            //Case b
            else if (symbol == 'b')
            {
                int counter = 1;
                for (int col = 0; col < n; col++)
                {
                    if (col != 0 && col % 2 != 0)
                    {
                        for (int row = n - 1; row >= 0; row--)
                        {
                            matrix[row, col] = counter;
                            counter++;
                        }
                    }
                    else
                    {
                        for (int row = 0; row < n; row++)
                        {
                            matrix[row, col] = counter;
                            counter++;
                        }
                    }
                    Console.WriteLine();
                }

            }
            //Case c
            //Printing the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == n - 1)
                    {
                        Console.WriteLine(matrix[i, j]);
                        break;
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            

        }
    }
}
