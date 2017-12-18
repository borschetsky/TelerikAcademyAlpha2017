using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem09ReplaceTabgs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //
            string[] arr = input.Split(new string[] { ". " }, StringSplitOptions.RemoveEmptyEntries);
            List<string> result1 = new List<string>();
            //


            for (int i = 0; i < arr.Length; i++)
            {
                int startIndex = arr[i].IndexOf("<a");
                int endIndex = arr[i].LastIndexOf("</a>");
                string result = arr[i].Substring(startIndex, endIndex - startIndex + 4);
                int firtsIndexOfReplaceUrl = result.IndexOf("<");
                int lastIndexOfReplaceUrl = result.IndexOf(">");
                string urlForRplace = result.Substring(firtsIndexOfReplaceUrl, lastIndexOfReplaceUrl - firtsIndexOfReplaceUrl + 1);
                int firstIndexOfCav = result.IndexOf("\"");
                int lastIndexOfCav = result.LastIndexOf("\"");
                string url = result.Substring(firstIndexOfCav + 1, lastIndexOfCav - firstIndexOfCav - 1);
                int firstIndexOfText = result.IndexOf(">");
                int lastIndexOfText = result.LastIndexOf("<");
                string text = result.Substring(firstIndexOfText + 1, lastIndexOfText - firstIndexOfText - 1);
                string urlResult = "(" + url + ")";
                string textResult = "[" + text + "]";
                string res = arr[i].Replace(urlForRplace, urlResult);
                int fIndexOfres = res.IndexOf(")");
                int lIndexOfres = res.IndexOf("a>");
                string textForreplace = res.Substring(fIndexOfres + 1, lIndexOfres - fIndexOfres + 1);
                string newres = res.Replace(textForreplace, textResult);
                string replacer = textResult + urlResult;
                string whatToReplace = urlResult + textResult;
                int repStartIndex = newres.IndexOf("(");
                int repEndIndex = newres.LastIndexOf("]");
                string oneMoreResult = newres.Replace(whatToReplace, replacer);
                result1.Add(oneMoreResult);


            }

            Console.WriteLine(string.Join(". ", result1));
            //string teest = arr[0];
            //string t2 = arr[1];
            //Console.WriteLine(teest);
            //Console.WriteLine(t2);
        }
    }
}
