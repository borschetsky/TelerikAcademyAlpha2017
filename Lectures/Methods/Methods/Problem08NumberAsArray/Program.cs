using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem08NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraysLengt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstArr = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secArr = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> result = new List<int>();
            

            int minLenght = Math.Min(arraysLengt[0], arraysLengt[1]);
            int maxLenght = Math.Max(arraysLengt[0], arraysLengt[1]);
            int[] result = new int[maxLenght];
            for (int i = 0; i < minLenght; i++)
            {
                int elementSum = firstArr[i] + secArr[i];
                if (elementSum <= 9)
                {
                    result[i] = elementSum;
                }
                else if(elementSum > 9)
                {
                    int secNum = elementSum % 10;
                    result[i] = secNum;
                    int firstNum = elementSum / 10;
                    if (firstArr.Count >= i + 1)
                    {
                        firstArr[i + 1] += firstNum;
                    }
                    else if (secArr.Count >= i + 1)
                    {
                        secArr[i + 1] += firstNum;
                    }

                }
            }

            if (arraysLengt[0] != arraysLengt[1])
            {
                if (result.Length == firstArr.Count)
                {
                    result[maxLenght - 1] = firstArr[maxLenght - 1];
                }
                else if (result.Length == secArr.Count)
                {
                    result[maxLenght - 1] = secArr[maxLenght - 1];
                }
            }
            

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
