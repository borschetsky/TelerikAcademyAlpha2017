using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int numer = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(ReturnLastDigitName(numer));

            
        }
        public static string ReturnLastDigitName (int number)
        {
            string nameOfDigit = "";

            if (number % 10 == 0)
            {
                nameOfDigit = "zero";
            }
            else if (number % 10 == 1)
            {
                nameOfDigit = "one";
            }
            else if (number % 10 == 2)
            {
                nameOfDigit = "two";
            }
            else if (number % 10 == 3)
            {
                nameOfDigit = "three";
            }
            else if (number % 10 == 4)
            {
                nameOfDigit = "four";
            }
            else if (number % 10 == 5)
            {
                nameOfDigit = "five";
            }
            else if (number % 10 == 6)
            {
                nameOfDigit = "six";
            }
            else if (number % 10 == 7)
            {
                nameOfDigit = "seven";
            }
            else if (number % 10 == 8)
            {
                nameOfDigit = "eight";
            }
            else if (number % 10 == 9)
            {
                nameOfDigit = "nine";
            }
            else if (number % 10 == 0)
            {
                nameOfDigit = "zero";
            }
            return nameOfDigit;

        }
    }
}
