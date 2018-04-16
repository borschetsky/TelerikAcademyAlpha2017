using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01StudentsOrderCustomLinkedLinst
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            var dict = new Dictionary<string, Node>();
            var alphaSudents = Console.ReadLine().Split().Select(s => new Node(s)).ToArray();
            //Connection of Nodes
            for (int i = 0; i < alphaSudents.Length - 1; i++)
            {
                alphaSudents[i].Connect(alphaSudents[i + 1]);
                dict.Add(alphaSudents[i].Value, alphaSudents[i]);
                if (i == alphaSudents.Length - 2)
                {
                    dict.Add(alphaSudents[alphaSudents.Length - 1].Value, alphaSudents[alphaSudents.Length - 1]);
                }
            }

            //foreach (var student in alphaSudents)
            //{
            //    dict.Add(student.Value, student);
            //}
            //head & tail
            var headtwo = dict.FirstOrDefault().Value; 
            

            for (int i = 0; i < n[1]; i++)
            {
                var pair = Console.ReadLine().Split();
                var first = pair[0];
                var second = pair[1];
                var student2Find = dict[first];
                
                var prev = student2Find.Left;
                var next = student2Find.Right;
                student2Find.Disconnect();
                if (prev != null && next != null)
                {
                    prev.Connect(next);
                }
                if (prev == null)
                {
                    headtwo = next;
                }
                var nextStudentToFind = dict[second]; 
                var nextSutedtPrev = nextStudentToFind.Left;
                if (nextSutedtPrev == null)
                {
                    student2Find.Connect(nextStudentToFind);
                    headtwo = student2Find;
                }
                else
                {
                    nextSutedtPrev.Connect(student2Find);
                    student2Find.Connect(nextStudentToFind);
                }
            }
            Console.WriteLine(string.Join(" ", headtwo));
        }

        public class Node : IEnumerable<string>
        {
            public Node(string val)
            {
                this.Value = val;
                this.Left = null;
                this.Right = null;
            }
            public string Value { get; }
            public Node Right { get; private set; }
            public Node Left { get; private set; }
            public void Connect(Node node)
            {
                if (node != null)
                {
                    this.Right = node;
                }
                if (this != null)
                {
                    node.Left = this;
                }
            }
            public void Disconnect()
            {
                if (this.Right != null)
                {
                    this.Right.Left = null;
                }
                if (this.Left != null)
                {
                    this.Left.Right = null;
                }
                this.Right = null;
                this.Left = null;
            }
            public IEnumerator<string> GetEnumerator()
            {
                var node = this;
                while (node != null)
                {
                    yield return node.Value;
                    node = node.Right;
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
