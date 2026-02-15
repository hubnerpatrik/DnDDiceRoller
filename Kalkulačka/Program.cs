using System;


class Program
{
    // Tady program začíná
    static void Main()
    {
        // Vytvoříme náhodný generátor čísel (pro kostky)
        Random nahodne = new Random();

        // Vypíšeme uvítací text
        Console.WriteLine("===================================");
        Console.WriteLine("  D&D Házečka Kostkami");
        Console.WriteLine("===================================");
        Console.WriteLine();

        // Tato smyčka se opakuje pořád dokola, dokud uživatel neřekne "konec"
        while (true)
        {
            // Ukážeme menu s možnostmi
            Console.WriteLine("\nVyberte kostku:");
            Console.WriteLine("1 - d4   (čtyřstěnná)");
            Console.WriteLine("2 - d6   (klasická hrací)");
            Console.WriteLine("3 - d8   (osmistěnná)");
            Console.WriteLine("4 - d10  (desetistěnná)");
            Console.WriteLine("5 - d12  (dvanáctistěnná)");
            Console.WriteLine("6 - d20  (nejpoužívanější v D&D)");
            Console.WriteLine("7 - d100 (percentile dice)");
            Console.WriteLine();
            Console.WriteLine("0 - Konec (ukončí program)");
            Console.WriteLine();
            Console.Write("Vaše volba: ");

            // Přečteme, co uživatel napsal
            string volba = Console.ReadLine();

            // Podle volby hodíme příslušnou kostkou
            if (volba == "1")
            {
                // Hodíme d4 - vylosujeme číslo mezi 1 a 4
                int vysledek = nahodne.Next(1, 5); // 5 je exkluzivní, takže max je 4
                Console.WriteLine($"\n🎲 Hodil jsi d4: {vysledek}");
            }
            else if (volba == "2")
            {
                // Hodíme d6 - vylosujeme číslo mezi 1 a 6
                int vysledek = nahodne.Next(1, 7);
                Console.WriteLine($"\n🎲 Hodil jsi d6: {vysledek}");
            }
            else if (volba == "3")
            {
                // Hodíme d8 - vylosujeme číslo mezi 1 a 8
                int vysledek = nahodne.Next(1, 9);
                Console.WriteLine($"\n🎲 Hodil jsi d8: {vysledek}");
            }
            else if (volba == "4")
            {
                // Hodíme d10 - vylosujeme číslo mezi 1 a 10
                int vysledek = nahodne.Next(1, 11);
                Console.WriteLine($"\n🎲 Hodil jsi d10: {vysledek}");
            }
            else if (volba == "5")
            {
                // Hodíme d12 - vylosujeme číslo mezi 1 a 12
                int vysledek = nahodne.Next(1, 13);
                Console.WriteLine($"\n🎲 Hodil jsi d12: {vysledek}");
            }
            else if (volba == "6")
            {
                // Hodíme d20 - nejdůležitější kostka v D&D!
                int vysledek = nahodne.Next(1, 21);
                Console.WriteLine($"\n🎲 Hodil jsi d20: {vysledek}");

                // Speciální zprávy pro kritické hody
                if (vysledek == 20)
                {
                    Console.WriteLine("⭐ KRITICKÝ ÚSPĚCH! ⭐");
                }
                else if (vysledek == 1)
                {
                    Console.WriteLine("💥 KRITICKÝ NEÚSPĚCH! 💥");
                }
            }
            else if (volba == "7")
            {
                // Hodíme d100 - vylosujeme číslo mezi 1 a 100
                int vysledek = nahodne.Next(1, 101);
                Console.WriteLine($"\n🎲 Hodil jsi d100: {vysledek}");
            }
            else if (volba == "0")
            {
                // Uživatel chce ukončit program
                Console.WriteLine("\nKonec programu.");
                break; // Toto ukončí while smyčku
            }
            else
            {
                // Uživatel zadal něco jiného
                Console.WriteLine("\n❌ Neplatná volba! Zadej číslo od 0 do 7.");
            }

            // Malá pauza pro lepší čitelnost
            Console.WriteLine("\n-----------------------------------");
        }
    }
}