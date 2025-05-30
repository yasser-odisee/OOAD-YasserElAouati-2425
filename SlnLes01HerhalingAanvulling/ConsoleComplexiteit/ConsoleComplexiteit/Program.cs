using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Geef een woord (enter om te stoppen): ");
            string woord = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(woord))
            {
                Console.WriteLine("\nBedankt en tot ziens.");
                break;
            }

            int aantalKarakters = woord.Length;
            int aantalLettergrepen = AantalLettergrepen(woord);
            double complexiteit = Complexiteit(woord);

            Console.WriteLine($"aantal karakters: {aantalKarakters}");
            Console.WriteLine($"aantal lettergrepen: {aantalLettergrepen}");
            Console.WriteLine($"complexiteit: {complexiteit:F1}\n");
        }
    }

    static bool IsKlinker(char c)
    {
        char lowerC = char.ToLower(c);
        return "aeiouy".Contains(lowerC);
    }

    static int AantalLettergrepen(string woord)
    {
        int lettergrepen = 0;
        bool vorigeWasKlinker = false;

        foreach (char c in woord)
        {
            if (IsKlinker(c))
            {
                if (!vorigeWasKlinker)
                {
                    lettergrepen++;
                }
                vorigeWasKlinker = true;
            }
            else
            {
                vorigeWasKlinker = false;
            }
        }
        return lettergrepen > 0 ? lettergrepen : 1;
    }

    static double Complexiteit(string woord)
    {
        int aantalKarakters = woord.Length;
        int aantalLettergrepen = AantalLettergrepen(woord);
        bool bevatXyq = woord.ToLower().IndexOfAny(new char[] { 'x', 'y', 'q' }) >= 0;

        double complexiteit = (aantalKarakters / 3.0) + aantalLettergrepen;
        if (bevatXyq)
        {
            complexiteit += 1;
        }
        return Math.Round(complexiteit, 1);
    }
}
