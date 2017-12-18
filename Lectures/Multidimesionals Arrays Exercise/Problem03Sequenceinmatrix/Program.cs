using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03Sequenceinmatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[sizeOfMatrix[0], sizeOfMatrix[1]];
            
            List<int> sequenceInRows = new List<int>();
            List<int> sequenceInCols = new List<int>();

            //Filling the matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine().Split(new string[] { " " },
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];

                }
            }
            
            //Comparing rows
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sequenceCounter = 1;
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == matrix[row, col - 1])
                    {
                        sequenceCounter++;
                    }
                    
                    
                }
                sequenceInRows.Add(sequenceCounter);
                sequenceCounter = 0;
            }
            //Comparing cols
            
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sequenceCounterCols = 1;
                for (int row = 1; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] == matrix[row - 1, col])
                    {
                        sequenceCounterCols++;
                    }
                    
                }
                sequenceInCols.Add(sequenceCounterCols);
                sequenceCounterCols = 0;
            }
            Console.WriteLine(string.Join(",", sequenceInRows));
            Console.WriteLine(string.Join(",", sequenceInCols));

        }
    }
}
