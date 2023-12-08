namespace SitoE
{
    internal class Program
    {
        static void Main()
        {
            int n = 100;
            bool[] liczbyPierwsze = new bool[n + 1];

            Tablica(liczbyPierwsze);

            Sito(liczbyPierwsze);

            WyswietlanieLiczbPierwszych(liczbyPierwsze);
        }

        private static void Tablica(bool[] LiczbyPierwsze)
        {
            int n = LiczbyPierwsze.Length - 1;

            for (int i = 2; i <= n; i++)
            {
                LiczbyPierwsze[i] = true;
            }
        }

        private static void Sito(bool[] LiczbyPierwsze)
        {
            int n = LiczbyPierwsze.Length - 1;
            int pierwiastekN = (int)Math.Sqrt(n);

            for (int i = 2; i <= pierwiastekN; i++)
            {
                if (LiczbyPierwsze[i])
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        LiczbyPierwsze[j] = false;
                    }
                }
            }
        }

        private static void WyswietlanieLiczbPierwszych(bool[] LiczbyPierwsze)
        {
            Console.WriteLine("Liczby pierwsze od 2 do 100");
            for (int i = 2; i < LiczbyPierwsze.Length; i++)
            {
                if (LiczbyPierwsze[i])
                {
                    Console.Write(i + ", ");

                }

            }
            Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }
    }
}