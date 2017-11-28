using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem10Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            BigInteger fact = 1;

            if (a == 0)
            {
                Console.WriteLine(1);
                return;
            }
            do
            {
                fact = fact * a;
                a--;
            } while (a > 1);
            Console.WriteLine(fact);
        }
    }
}
