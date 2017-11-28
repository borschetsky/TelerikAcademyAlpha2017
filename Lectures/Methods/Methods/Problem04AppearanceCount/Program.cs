using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04AppearanceCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            int[] array = new int[sizeOfArray];
            int[] splitedArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int searchingNum = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberAppearence(splitedArray, searchingNum));

        }

        public static int NumberAppearence(int[] arr, int num)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    counter++;
                }
            }
            return counter;
        }


    }
}
