namespace HiLoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w HiLo!");
            Console.WriteLine($"Odgadnij liczbę od 1 do {HiLoGame.MAXIMUM}.");
            HiLoGame.Hint();
            while(HiLoGame.GetPot() > 0)
            {
                Console.WriteLine("Wciśnij [w]iększa, [m]niejsza lub [?] kupno wskazówki");
                Console.WriteLine($"Inne klawisze to koniec gry z {HiLoGame.GetPot()}zł.");
                char keyChar = Console.ReadKey(true).KeyChar;
                if (keyChar == 'w')
                    HiLoGame.Guess(true);
                else if (keyChar == 'm')
                    HiLoGame.Guess(false);
                else if (keyChar == '?')
                    HiLoGame.Hint();
                else
                    return;
            }
            Console.WriteLine("Skończyły Ci się pieniądze. Do zobaczenia!");
        }
    }
}
