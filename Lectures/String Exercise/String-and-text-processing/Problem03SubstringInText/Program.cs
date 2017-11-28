using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03SubstringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            int counter = 0;
            int index = text.IndexOf(pattern, StringComparison.InvariantCultureIgnoreCase);
            //Solution

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1, StringComparison.InvariantCultureIgnoreCase);
            }

            Console.WriteLine(counter);

            
        }
    }
}
