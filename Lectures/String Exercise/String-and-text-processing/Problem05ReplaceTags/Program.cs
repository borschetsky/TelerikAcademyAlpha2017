using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                int stars = 20 - input.Length;
                Console.Write(input);
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
            }
            else
            {
                Console.WriteLine(input);
            }
        }
    }
}
