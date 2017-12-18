using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty_SelfCodding
{
    class Program
    {
        //input
        static char[] stuff;
        static int[] moves;
        //inventory
        static int inventorySouls = 0;
        static int inventoryFood = 0;
        //counters
        static int deadlockPassed = 0;
        static int kittyPosition = 0;
        static int movesPasse = 0;
        //Kitty status
        static bool isKittyAlive = true;
        //
        const char soul = '@';
        const char food = '*';
        const char deadlock = 'x';
        const char emptySpace = '0';

        static void Main(string[] args)
        {
            //filling iteams
            stuff = Console.ReadLine().ToCharArray();
            moves = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //solving
            Collector();
            foreach (var move in moves)
            {
                if (!isKittyAlive)
                {
                    break;
                }
                CountingIndexOfKitty(move);
                Collector();
            }

            if (isKittyAlive)
            {
                Console.WriteLine($"Coder souls collected: {inventorySouls}\nFood collected: {inventoryFood}\nDeadlocks: {deadlockPassed}");
            }
            else
            {
                Console.WriteLine($"You are deadlocked, you greedy kitty!\nJumps before deadlock: {movesPasse}");
            }

        }

        private static void CountingIndexOfKitty(int move)
        {
            var currentKittyPosition = kittyPosition + move;
            while (currentKittyPosition < 0)
            {
                currentKittyPosition += stuff.Length;
            }
            while (currentKittyPosition >= stuff.Length)
            {
                currentKittyPosition -= stuff.Length;
            }
            kittyPosition = currentKittyPosition;
            movesPasse++;
        }

        private static void Collector()
        {
            switch (stuff[kittyPosition])
            {
                case soul:
                    inventorySouls++;
                    stuff[kittyPosition] = emptySpace;
                    break;
                case food:
                    inventoryFood++;
                    stuff[kittyPosition] = emptySpace;
                    break;
                case deadlock:
                    if (kittyPosition % 2 == 0)
                    {
                        if (inventorySouls < 1)
                        {
                            isKittyAlive = false;
                            break;
                        }
                        inventorySouls--;
                        stuff[kittyPosition] = soul;
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
                        stuff[kittyPosition] = food;
                        deadlockPassed++;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
