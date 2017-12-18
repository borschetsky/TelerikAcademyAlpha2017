using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem01SendMeTheCode
{
    class Program
    {
        static void Main(string[] args)
        {
            

            char[] input = Console.ReadLine().ToCharArray();
            long[] digits = new long[input.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                if (input[i] != '-')
                {
                    digits[i] = (long)char.GetNumericValue(input[i]);
                }
                
            }
            Array.Reverse(digits);
            char[] abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            BigInteger result = 0;
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < digits.Length; i++)
            {
                BigInteger currentResult = 0; ;
                int index = i + 1;
                if (index % 2 != 0)
                   currentResult = (BigInteger)(digits[i] * Math.Pow(index, 2));
                else
                    currentResult = (BigInteger)Math.Pow(digits[i], 2) * index;
                
                result += currentResult;
            }

            if (result % 10 == 0)
            {
                Console.WriteLine("10\nBig Vik wins again!");
                return;
            }
            BigInteger lenghtOfMessage = result % 10;
            BigInteger remainder = result % 26;
           

            for (int i = 0; i < lenghtOfMessage; i++)
            {

                BigInteger currentLetterIndex = i + remainder;
                while (currentLetterIndex >= abc.Length)
                {
                    currentLetterIndex -= abc.Length;
                }
                res.Append(abc[(int)currentLetterIndex]);
                //if (currentLetterIndex <= abc.Length - 1)
                //{
                //    res.Append(abc[currentLetterIndex]);
                //}
                //else
                //{
                //    while (currentLetterIndex > abc.Length)
                //    {
                //        currentLetterIndex -= abc.Length;
                //    }


                //}
                //res.Append(abc[currentLetterIndex]);

            }
            Console.WriteLine("{0}\n{1}",result ,res.ToString());

                  
        }
    }
}
