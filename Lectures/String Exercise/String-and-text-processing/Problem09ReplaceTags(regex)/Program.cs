using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem09ReplaceTags_regex_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"<a\s+href\s?=\s?""(http:\/\/)?(\w+.\w+.?\w+)"">(\w+\s+\w+)<\/a>";
            Match mtc = Regex.Match(input, patern);

            var output = mtc.Groups[2].Value;

            Console.WriteLine(output);

        }
    }
}
