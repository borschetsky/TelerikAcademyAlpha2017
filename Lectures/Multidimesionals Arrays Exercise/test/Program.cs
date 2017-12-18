using System;

namespace december18problem05christmashat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            //balabon
            int baloonNumOfDots = inputNumber * 2 - 1;

            Console.WriteLine("{0}/|\\{0}", new string('.', baloonNumOfDots));
            Console.WriteLine("{0}\\|/{0}", new string('.', baloonNumOfDots));
            //end of baloon
            //midle part
            Console.WriteLine("{0}***{0}", new string('.', baloonNumOfDots));
            int middlePartCountOfDots = inputNumber * 2 - 2;
            int middlePartCountOfDashes = 1;
            for (int i = 0; i < inputNumber * 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}",
                                  new string('.', middlePartCountOfDots),
                                  new string('-', middlePartCountOfDashes));
                middlePartCountOfDots--;
                middlePartCountOfDashes++;
            }
            //lower part
            int lowerPartCountOfStars = inputNumber * 2;

            Console.WriteLine("{0}*{0}", new string('*', lowerPartCountOfStars));
            for (int i = 0; i < inputNumber * 2; i++)
            {
                Console.Write("*.");
            }
            Console.Write("*");
            Console.WriteLine();
            Console.WriteLine("{0}*{0}", new string('*', lowerPartCountOfStars));
        }
    }
}
