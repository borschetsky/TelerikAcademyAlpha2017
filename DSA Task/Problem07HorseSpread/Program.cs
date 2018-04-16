using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem07HorseSpread
{
    class Program
    {
        static int[,] matrix;

        static void Main(string[] args)
        {
            int matrixRow = int.Parse(Console.ReadLine());
            int matrixCol = int.Parse(Console.ReadLine());
            int startingRow = int.Parse(Console.ReadLine());
            int startingCol = int.Parse(Console.ReadLine());

            matrix = new int[matrixRow, matrixCol];

            matrix[startingRow, startingCol] = 1;
            HorseBFS(new Position(startingRow, startingCol), matrix);
            //MatrixPrint(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, matrix.GetLength(1) / 2]);
            }
        }
        static void HorseBFS(Position p, int [,] matrix)
        {
            var queue = new Queue<Position>();
            queue.Enqueue(p);
            while (queue.Count > 0)
            {
                var currentPos = queue.Dequeue();
                //upLeft
                int newRow = currentPos.Row - 2;
                int newCol = currentPos.Col - 1;
                if (!(newRow < 0 || newCol < 0) && !(matrix[newRow, newCol] > 0))
                {
                    var currentvalue = matrix[currentPos.Row, currentPos.Col];
                    var newvalue = currentvalue + 1;
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
                //upRight
                newRow = currentPos.Row - 2;
                newCol = currentPos.Col + 1;
                if (!(newRow < 0 || newCol > matrix.GetLength(1) - 1) && !(matrix[newRow, newCol] > 0))
                {
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
                //leftUp
                newRow = currentPos.Row - 1;
                newCol = currentPos.Col - 2;
                if (!(newRow < 0 || newCol < 0) && !(matrix[newRow, newCol] > 0))
                {
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
                //leftDown
                newRow = currentPos.Row + 1;
                newCol = currentPos.Col - 2;
                if (!(newRow > matrix.GetLength(0) - 1 || newCol < 0) && !(matrix[newRow, newCol] > 0))
                {
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
                //rightUp
                newRow = currentPos.Row - 1;
                newCol = currentPos.Col + 2;
                if (!(newRow < 0 || newCol > matrix.GetLength(1) - 1) && !(matrix[newRow, newCol] > 0))
                {
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
                //rightDonw
                newRow = currentPos.Row + 1;
                newCol = currentPos.Col + 2;
                if (!(newRow > matrix.GetLength(0) - 1 || newCol > matrix.GetLength(1) - 1) && !(matrix[newRow, newCol] > 0))
                {
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
                //downLeft
                newRow = currentPos.Row + 2;
                newCol = currentPos.Col - 1;
                if (!(newRow > matrix.GetLength(0) - 1 || newCol < 0) && !(matrix[newRow, newCol] > 0))
                {
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
                //downRight
                newRow = currentPos.Row + 2;
                newCol = currentPos.Col + 1;
                if (!(newRow > matrix.GetLength(0) - 1 || newCol > matrix.GetLength(1) - 1) && !(matrix[newRow, newCol] > 0))
                {
                    matrix[newRow, newCol] = matrix[currentPos.Row, currentPos.Col] + 1;
                    queue.Enqueue(new Position(newRow, newCol));
                }
            }
            

        }
        static void MatrixPrint(int[,] matrix)
        {
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
    internal struct Position
    {
        public Position(int row, int col)
        {
            this.Row = row;
            this.Col = col;
          
        }
        public int Row { get; set; }
        public int Col { get; set; }
    }
        
}
