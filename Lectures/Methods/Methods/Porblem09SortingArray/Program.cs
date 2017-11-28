using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porblem09SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Porblem09SortingArray(arr);
            

            
        }

        private static void Porblem09SortingArray(int[] arr)
        {
            Array.Sort(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
