using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04ParseTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string upCaseStartPattern = "<upcase>";
            string upCaseEndPattern = "</upcase>";
            string input = Console.ReadLine();
            int currentStartIndex = input.IndexOf(upCaseStartPattern);
            int currentEndIndex = input.IndexOf(upCaseEndPattern);
            while (currentStartIndex != -1 && currentEndIndex != -1)
            {
                string textForChanging = input.Substring(currentStartIndex+8, currentEndIndex-(currentStartIndex+8)).ToUpper();
                input = input.Replace(input.Substring(currentStartIndex,(currentEndIndex+9)-currentStartIndex), textForChanging.ToUpper());
                currentStartIndex = input.IndexOf(upCaseStartPattern);
                currentEndIndex = input.IndexOf(upCaseEndPattern);
            }
            Console.WriteLine(input);


        }
    }
}
