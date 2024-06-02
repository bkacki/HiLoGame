using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiLoGame
{
    internal static class HiLoGame
    {
        public const int MAXIMUM = 10;
        private static Random random = new Random();
        private static int currentNumber = random.Next(1, (MAXIMUM+1));
        private static int nextNumber;
        private static int pot = 10;
        public static int GetPot() { return pot; }

        public static void Guess(bool higherOrLower)
        {
            nextNumber = random.Next(1, (MAXIMUM + 1));

            if (higherOrLower && (nextNumber >= currentNumber))
            {
                Console.WriteLine("Zgadłeś!");
                pot++;
            }
            else if (!higherOrLower && (nextNumber <= currentNumber))
            {
                Console.WriteLine("Zgadłeś!");
                pot++;
            }
            else
            {
                Console.WriteLine("Niestety błędna odpowiedź.");
                pot--;
            }
            currentNumber = nextNumber;
            Console.WriteLine($"Aktualna wartość to: {currentNumber}");
        }

        public static void Hint()
        {
            int halfOfMaximum = MAXIMUM / 2;

            if (currentNumber >= halfOfMaximum)
                Console.WriteLine($"Liczba wynosi co najmniej {halfOfMaximum}");
            else
                Console.WriteLine($"Liczba jest mniejsza niż {halfOfMaximum}");

            pot--;
        }
    }
}
