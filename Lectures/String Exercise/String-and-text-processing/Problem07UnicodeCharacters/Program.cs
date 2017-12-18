using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem07UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            

            foreach (char symbol in input)
            {
                Console.Write("\\u{0:X4}", (int)symbol);
            }
            Console.WriteLine();

        }
    }
}
