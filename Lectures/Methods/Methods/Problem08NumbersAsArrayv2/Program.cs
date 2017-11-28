using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08NumbersAsArrayv2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizesOfArray = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int[] firstArray = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split().Select(Int32.Parse).ToArray();

            ProcessArrays(firstArray, secondArray);
        }

        private static void ProcessArrays(int[] firstArray, int[] secondArray)
        {
            List<int> result = new List<int>();
            int longestArray = Math.Max(firstArray.Length, secondArray.Length);
            int remainder = 0;
            int currentSum = 0;
            for (int i = 0; i < longestArray; i++)
            {
                currentSum = remainder;
                if (i < firstArray.Length)
                    currentSum += firstArray[i];
                if (i < secondArray.Length)
                    currentSum += secondArray[i];
                result.Add(currentSum % 10);
                remainder = currentSum / 10;
            }
            Console.Write(result[0]);
            for (int i = 1; i < result.Count; i++)
            {
                Console.Write(" " + result[i]);
            }
        }
    }   
}
}
