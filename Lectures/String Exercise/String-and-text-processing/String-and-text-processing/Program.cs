using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_and_text_processing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = Console.ReadLine().ToCharArray();
            char[] reverseString = new char[charArr.Length];

            for (int i = charArr.Length - 1; i >= 0; i--)
            {
                reverseString[charArr.Length - i - 1] = charArr[i];

            }
            reverseString.ToString();

            Console.WriteLine(reverseString);
        
        }
    }
}
