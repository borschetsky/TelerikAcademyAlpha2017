using System;
using System.Collections.Generic;
using System.Linq;

namespace TelerikExam11October
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            long sum = GettingIntegersFormString(Console.ReadLine());

            while (sum > 9)
            {
                sum = SummingNumbers(sum);
            }
            Console.WriteLine(sum);
        }
        public static long GettingIntegersFormString(string input)
        {
            char[] chars = input.ToCharArray();
            List<char> kistInput = new List<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (chars[i] != '.' && chars[i] != '-')
                {
                    kistInput.Add(chars[i]);
                }
            }
            List<int> listOfInt = new List<int>();
            for (int i = 0; i < kistInput.Count(); i++)
            {
                int val = (int)Char.GetNumericValue(kistInput[i]);
                listOfInt.Add(val);
            }
            long sum = 0;
            for (int i = 0; i < listOfInt.Count(); i++)
            {
                sum += listOfInt[i];
            }
            return sum;
        }
        public static long SummingNumbers(long input)
        {
            string s = input.ToString();
            char[] c = s.ToCharArray();
            long sum = 0;
            for (int i = 0; i < c.Length; i++)
            {
                int val = (int)Char.GetNumericValue(c[i]);
                sum += val;
            }
            return sum;
        }
    }
}
