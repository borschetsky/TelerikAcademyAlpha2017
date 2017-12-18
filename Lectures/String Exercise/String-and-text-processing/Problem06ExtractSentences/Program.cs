using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06ExtractSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string[] arr = input.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();

            foreach (var sentence in arr)
            {
                var wordList = new List<string>();
                var strB = new StringBuilder();

                for (int i = 0; i < sentence.Length; i++)
                {
                    if (wordList.Contains(word))
                    {
                        list.Add(sentence.Trim() + ". ");
                        break;
                    }

                    if (char.IsLetter(sentence[i]))
                    {
                        strB.Append(sentence[i].ToString());
                    }
                    else
                    {
                        wordList.Add(strB.ToString());
                        strB = new StringBuilder();
                        
                    }
                }
                
            }

            //for (int i = 0; i < list.Count; i++)
            //{

            //    if (i == list.Count - 1)
            //    {
            //        Console.Write(list[i] + ".");
            //        Console.WriteLine();
            //    }
            //    else
            //        Console.Write(list[i] + ".");
            //}

            Console.WriteLine(string.Join("", list));
           

        }
    }
}
