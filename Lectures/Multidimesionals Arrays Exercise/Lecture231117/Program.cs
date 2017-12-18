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
            //Case bma
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
                    
                }

            }
            //Case c
            else if (symbol == 'c')
            {

                //Count of diagonals
                int couuntOfDiagonals = matrix.GetLength(0) + matrix.GetLength(1) - 1;
                int counter = 1;
                for (int i = 0; i < couuntOfDiagonals; i++)
                {
                    if (i < matrix.GetLength(0))
                    {
                        int row = matrix.GetLength(0) - 1 - i;
                        int col = 0;
                        for (int j = 0; j <= i; j++)
                        {
                            matrix[row, col] = counter;
                            col++;
                            row++;
                            counter++;
                        }
                    }
                    else
                    {
                        int col = i - matrix.GetLength(1) + 1;
                        int row = 0;
                        for (int j = i; j < couuntOfDiagonals; j++)
                        {
                            matrix[row, col] = counter;
                            col++;
                            row++;
                            counter++;

                        }
                    }
                }
            }
            //Case d spiral
            else if (symbol == 'd')
            {
                int counter = 1;
                string direction = "down";
                int[] position = { 0, 0 };
                for (int i = 0; i < n * n; i++)
                {
                    matrix[position[0], position[1]] = counter;
                    counter++;
                    switch (direction)
                    {
                        case "down":
                            if (position[0] + 1 < n && matrix[position[0] + 1, position[1]] == 0)
                                position[0]++;
                            else
                            {
                                direction = "right";
                                position[1]++;
                            }
                            break;
                        case "right":
                            if (position[1] + 1 < n && matrix[position[0], position[1] + 1] == 0)
                                position[1]++;
                            else
                            {
                                direction = "up";
                                position[0]--;
                            }
                            break;
                        case "up":
                            if (position[0] > 0 && matrix[position[0] - 1, position[1]] == 0)
                            {
                                position[0]--;
                            }
                            else
                            {
                                direction = "left";
                                position[1]--;
                            }
                            break;
                        case "left":
                            if (position[1] > 0 && matrix[position[0], position[1] - 1] == 0)
                            {
                                position[1]--;
                            }
                            else
                            {
                                direction = "down";
                                position[0]++;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
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
                
            }

            

        }
    }
}
