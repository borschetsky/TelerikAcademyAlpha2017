using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01StudentsOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            string[] alphaStudents = Console.ReadLine().Split();
            var linked = new LinkedList<string>();
            foreach (var student in alphaStudents)
            {
                linked.AddLast(student);
            }
            for (int i = 0; i < n[1]; i++)
            {
                var pair = Console.ReadLine().Split();
                var first = pair[0];
                var second = pair[1];
                foreach (var linkedStud in linked)
                {
                    if (linkedStud == first)
                    {
                        linked.Remove(linkedStud);
                        foreach (var linkedStudSecond in linked)
                        {
                            if (linkedStudSecond == second)
                            {
                                var node = linked.Find(second);
                                linked.AddBefore(node, first);
                                break;
                            }
                        }
                        break;
                    }   
                }
            }

            Console.WriteLine(string.Join(" ", linked));
        }
    }

    
}
