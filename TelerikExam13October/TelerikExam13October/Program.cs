using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long[] wallHeight =
                Console.ReadLine()
                       .Split(new char[] { ' ' }, StringSplitOptions
                              .RemoveEmptyEntries)
                       .Select(long.Parse).ToArray();
            List<long> wallDiff = new List<long>();
            for (int i = 1; i < wallHeight.Length; i++)
            {
                long wallABS = Math.Abs(wallHeight[i] - wallHeight[i - 1]);
                if (wallDiff.Count < 1 || wallDiff[i - 2] == 0)
                {
                    wallDiff.Add(wallABS);
                }
                else
                {
                    if (wallDiff[i - 2] % 2 == 0)
                        wallDiff.Add(0);
                    else
                        wallDiff.Add(wallABS);
                }
            }
            long sum = 0;
            for (int i = 0; i < wallDiff.Count; i++)
            {
                if (wallDiff[i] % 2 == 0)
                {
                    sum += wallDiff[i];
                }
            }
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
