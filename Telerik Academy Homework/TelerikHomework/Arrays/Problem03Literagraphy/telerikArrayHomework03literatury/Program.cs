using System;

namespace telerikArrayHomework03literatury
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please enter first string");
            string firstString = Console.ReadLine();
			//Console.WriteLine("Please enter second string");
			string secondString = Console.ReadLine();
            //now parsing to arrays of chars
            char[] firstArray = firstString.ToCharArray();
            char[] secondArray = secondString.ToCharArray();
            //then we need minimum lenght one of the arrays
            int minArrayLenght = Math.Min(firstArray.Length, secondArray.Length);
            //then, we need to compare each char of array and try to found on 
            //which index might be diiferences
            int indexOfDifference = 0;
            //here we will compare two arrays if one of their index is different
            //and if it is we will stop cycle
            for (int i = 0; i < minArrayLenght; i++)
            {
                indexOfDifference = i;
                if (firstArray[i] != secondArray[i])
                {
                    break;
                }
            }
            //then we will chech the differences usind if-else construction
            if (firstArray[indexOfDifference] > secondArray[indexOfDifference])
            {
                Console.WriteLine(">");
            }
            else if (firstArray[indexOfDifference] < secondArray[indexOfDifference])
            {
                Console.WriteLine("<");
            }
            else if (indexOfDifference != firstArray.Length - 1)
            {
                Console.WriteLine(">");
            }
            else if (indexOfDifference != secondArray.Length - 1)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
