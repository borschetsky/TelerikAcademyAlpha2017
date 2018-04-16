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
            string[] students = Console.ReadLine().Split();
            
            var alphaSudents = Console.ReadLine().Split().Select(s => new Node(s)).ToArray();
            //Connection of Nodes
            for (int i = 0; i < alphaSudents.Length - 1; i++)
            {
                alphaSudents[i].Connect(alphaSudents[i + 1]);
            }
            //head & tail
            var head = alphaSudents[0];
            //var tail = alphaSudents[alphaSudents.Length - 1];

            for (int i = 0; i < n[1]; i++)
            {
                var pair = Console.ReadLine().Split();
                var first = pair[0];
                var second = pair[1];
                foreach (var student in alphaSudents)
                {
                    var studentToFind = first;
                    if (studentToFind == student.Value)
                    {
                        var prev = student.Left;
                        var next = student.Right;
                        student.Disconnect();
                        if (prev != null && next != null)
                        {
                            prev.Connect(next);
                        }
                        if (prev == null)
                        {
                            head = next;
                        }
                        
                        foreach (var nextStudent in alphaSudents)
                        {
                            if (nextStudent.Value == second)
                            {
                                var nextStudentPrev = nextStudent.Left;
                                
                                if (nextStudentPrev == null)
                                {
                                    student.Connect(nextStudent);
                                    head = student;
                                }
                                else
                                {
                                    nextStudentPrev.Connect(student);
                                    student.Connect(nextStudent);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", head));
           
        }
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
