using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int firstMaxNum = MaxNumber(nums[0], nums[1]);
            int maxNum = MaxNumber(firstMaxNum, nums[2]);
            Console.WriteLine(maxNum);

        }

        public static int MaxNumber (int a, int b)
        {

            return Math.Max(a, b);
        }
    }
}
