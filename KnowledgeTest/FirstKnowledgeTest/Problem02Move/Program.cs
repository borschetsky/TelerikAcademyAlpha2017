using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02Move
{
    class Program
    {
        static int startingPosition;

        static void Main(string[] args)
        {
            startingPosition = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int forwardSum = 0;
            int backwardSum = 0;

            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "exit") break;
                string[] commd = cmd
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int times = int.Parse(commd[0]);
                string directions = commd[1];
                int size = int.Parse(commd[2]);
                
                if (directions == "forward")
                {
                    int targetPosition = startingPosition + times * size;
                    for (int i = startingPosition + size; i <= targetPosition; i+= size)
                    {
                        if (i > arr.Length - 1)
                        {
                            int currentNum = i % arr.Length;
                            forwardSum += arr[currentNum];
                        }
                        else
                        {
                            forwardSum += arr[i];
                        }
                    }

                    while (targetPosition > arr.Length - 1)
                    {
                        targetPosition = targetPosition - arr.Length;
                    }
                    startingPosition = targetPosition;
                }
                else if (directions == "backwards")
                {
                    int targetPosition = startingPosition - times * size;
                    for (int i = startingPosition - size; i >= targetPosition; i-= size)
                    {
                        int currentNum = i;
                        if (i < 0 || i > arr.Length - 1)
                        {
                            while (currentNum < 0) currentNum += arr.Length;
                            backwardSum += arr[currentNum];
                        }
                        else
                            backwardSum += arr[currentNum];
                    }
                    while (targetPosition < 0) targetPosition += arr.Length;
                    startingPosition = targetPosition;
                }
            }
            Console.WriteLine("Forward: {0}\nBackwards: {1}", forwardSum, backwardSum);
            
        }
    }
}
