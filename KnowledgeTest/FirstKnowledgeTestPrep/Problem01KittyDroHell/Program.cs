using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01KittyDroHell
{
    class Program
    {
        
        const char soul = '@';
        const char food = '*';
        const char deadlock = 'x';
        const char emptySpace = '0';

        static int kittyPosition = 0;
        static int movesPased = 0;
        static int deadlockPassed = 0;

        //Inventory
        static int inventorySoul = 0;
        static int inventoryFood = 0;
        //
        static bool isKittyAlive = true;
        static char[] container;
        static int[] kittyMoves;


        static void Main(string[] args)
        {
            container = Console.ReadLine().ToCharArray();
            kittyMoves = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            
            Collecting();

            foreach (var move in kittyMoves)
            {
                if (!isKittyAlive)
                {
                    break;
                }
                InicializationOfPOsition(move);
                Collecting();
            }

            if (isKittyAlive)
            {
                Console.WriteLine($"Coder souls collected: {inventorySoul}\nFood collected: {inventoryFood}\nDeadlocks: {deadlockPassed}");
            }
            else
            {
                Console.WriteLine($"You are deadlocked, you greedy kitty!\nJumps before deadlock: {movesPased}");
            }
        }

        private static void InicializationOfPOsition(int move)
        {
            var targetPosition = kittyPosition + move;

            while (targetPosition < 0)
            {
                targetPosition = targetPosition + container.Length;
            }
            while (targetPosition >= container.Length)
            {
                targetPosition -= container.Length;
            }
            kittyPosition = targetPosition;
            movesPased++;
        }

        private static void Collecting()
        {
            switch (container[kittyPosition])
            {
                case soul:
                    inventorySoul++;
                    container[kittyPosition] = emptySpace;
                    break;
                case food:
                    inventoryFood++;
                    container[kittyPosition] = emptySpace;
                    break;
                case deadlock:
                    if (kittyPosition % 2 == 0)
                    {
                        if (inventorySoul < 1)
                        {
                            isKittyAlive = false;
                            break;
                        }
                        inventorySoul--;
                        container[kittyPosition] = soul;
                        deadlockPassed++;
                    }
                    else
                    {
                        if (inventoryFood < 1)
                        {
                            isKittyAlive = false;
                            break;
                        }
                        inventoryFood--;
                        container[kittyPosition] = food;
                        deadlockPassed++;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
