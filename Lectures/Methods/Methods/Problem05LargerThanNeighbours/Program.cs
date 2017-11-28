using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[int.Parse(Console.ReadLine())];
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(LargerThanNeighbour(secondArr));

        }
        public static int LargerThanNeighbour (int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
