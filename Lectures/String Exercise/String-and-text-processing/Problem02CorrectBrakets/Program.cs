using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02CorrectBrakets
{
    class Program
    {
        static void Main(string[] args)
        {

            //string someString = Console.ReadLine();
            //if (someString.Where(currentChar => currentChar.Equals('(')).Count() == someString.Where(currentChar => currentChar.Equals(')')).Count())
            //    Console.WriteLine("Correct");
            //else
            //    Console.WriteLine("Incorrect");
            string input = Console.ReadLine();
            int openBraketCounter = 0;
            int closeBraketCounter = 0;
            //Lets count ")"
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBraketCounter++;
                }
                else if (input[i] == ')')
                {
                    closeBraketCounter++;
                }
            }

            

            if ( openBraketCounter == closeBraketCounter)
            {
                Console.WriteLine("Correct");
            }
            else
                Console.WriteLine("Incorrect");
        }
    }
}
