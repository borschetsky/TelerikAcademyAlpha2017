using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem11IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            NumsResult(nums);
            
        }

        private static void NumsResult(int[] nums)
        {
            Console.WriteLine(nums.Min());
            Console.WriteLine(nums.Max());
            Console.WriteLine("{0:F2}", nums.Average());
            Console.WriteLine(nums.Sum());
            BigInteger product = 1;
            foreach (var num in nums)
            {
                product *= num;
            }
            Console.WriteLine(product);
        }
    }
}
