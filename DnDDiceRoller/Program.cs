using System;

class DiceRoller
{
    static void Main()
    {
        Random nahodne = new Random();

        Console.WriteLine("===================================");
        Console.WriteLine("  D&D Hod Kostkou");
        Console.WriteLine("===================================");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("\nVyberte kostku:");
            Console.WriteLine("1 - d4   (čtyřstěnná)");
            Console.WriteLine("2 - d6   (klasická hrací)");
            Console.WriteLine("3 - d8   (osmistěnná)");
            Console.WriteLine("4 - d10  (desetistěnná)");
            Console.WriteLine("5 - d12  (dvanáctistěnná)");
            Console.WriteLine("6 - d20  (nejpoužívanější v D&D)");
            Console.WriteLine();
            Console.WriteLine("0 - Konec (ukončí program)");
            Console.WriteLine();
            Console.Write("Vaše volba: ");

            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    int vysledek1 = nahodne.Next(1, 5);
                    Console.WriteLine($"\nHodil jsi d4: {vysledek1}");
                    break;

                case "2":
                    int vysledek2 = nahodne.Next(1, 7);
                    Console.WriteLine($"\nHodil jsi d6: {vysledek2}");
                    break;

                case "3":
                    int vysledek3 = nahodne.Next(1, 9);
                    Console.WriteLine($"\nHodil jsi d8: {vysledek3}");
                    break;

                case "4":
                    int vysledek4 = nahodne.Next(1, 11);
                    Console.WriteLine($"\nHodil jsi d10: {vysledek4}");
                    break;

                case "5":
                    int vysledek5 = nahodne.Next(1, 13);
                    Console.WriteLine($"\nHodil jsi d12: {vysledek5}");
                    break;

                case "6":
                    int vysledek6 = nahodne.Next(1, 21);
                    Console.WriteLine($"\nHodil jsi d20: {vysledek6}");

                    if (vysledek6 == 20)
                    {
                        Console.WriteLine("KRITICKÝ ÚSPĚCH!");
                    }
                    else if (vysledek6 == 1)
                    {
                        Console.WriteLine("KRITICKÝ NEÚSPĚCH!");
                    }
                    break;

                case "0":
                    Console.WriteLine("\nKonec programu.");
                    return;

                default:
                    Console.WriteLine("\nNeplatná volba! Zadej číslo od 0 do 6.");
                    break;
            }

            Console.WriteLine("\n-----------------------------------");
        }
    }
}
