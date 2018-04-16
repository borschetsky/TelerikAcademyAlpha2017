using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Problem03SupermarketQueue
{
    class Program
    {
        static string error = "Error";
        static string ok = "OK";
        static Dictionary<string, int> dict;

        static void Main(string[] args)
        {
            var queue = new BigList<string>();
            dict = new Dictionary<string, int>();
            var result = new StringBuilder();
            var cmd = Console.ReadLine();

            while (cmd != "End")
            {
                var parameters = cmd.Split();
                switch (parameters[0])
                {
                    case "Append":
                        var name = parameters[1];
                        queue.Add(name);
                        AddingToDictionary(name);
                        result.AppendLine(ok);
                        break;
                    case "Find":
                        if (dict.ContainsKey(parameters[1]))
                        {
                            int res = dict[parameters[1]];
                            result.AppendLine(res.ToString());
                        }
                        else
                        {
                            result.AppendLine("0");
                        }
                        break;
                    case "Insert":
                        var position = int.Parse(parameters[1]);
                        name = parameters[2];
                        if (position <= queue.Count)
                        {
                            
                            queue.Insert(position, name);
                            AddingToDictionary(name);
                            result.AppendLine(ok);
                        }
                        else
                        {
                            result.AppendLine(error);
                        }
                        break;
                    case "Serve":
                        var count = int.Parse(parameters[1]);
                        if (count > queue.Count)
                        {
                            result.AppendLine(error);
                        }
                        else
                        {
                            var people = queue.GetRange(0, count).ToArray();
                            queue.RemoveRange(0, count);
                            foreach (var p in people)
                            {
                                dict[p]--;
                            }
                            result.AppendLine(String.Join(" ", people));
                        }
                        break;
                    default:
                        break;
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine(result.ToString().TrimEnd());

        }
        static void AddingToDictionary(string name)
        {
            if (!dict.ContainsKey(name))
            {
                dict.Add(name, 1);
            }
            else
            {
                dict[name]++;
            }
        }
    }
}
