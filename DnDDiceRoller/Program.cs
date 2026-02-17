using System;

class DiceRoller
{
    static Random random = new Random();

    static void Main()
    {
        PrintHeader();

        while (true)
        {
            PrintMenu();

            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("\nKonec programu.");
                return;
            }

            int sides = GetSides(input);

            if (sides == -1)
            {
                Console.WriteLine("\nNeplatná volba! Zadej číslo od 0 do 6.");
                continue;
            }

            int result = RollDice(sides);
            Console.WriteLine($"\nHodil jsi d{sides}: {result}");

            if (sides == 20)
                CheckCritical(result);

            Console.WriteLine("\n-----------------------------------");
        }
    }

    static void PrintHeader()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("   D&D Hod Kostkou");
        Console.WriteLine("===================================");
    }

    static void PrintMenu()
    {
        Console.WriteLine("\nVyberte kostku:");
        Console.WriteLine("1 - d4   (čtyřstěnná)");
        Console.WriteLine("2 - d6   (klasická hrací)");
        Console.WriteLine("3 - d8   (osmistěnná)");
        Console.WriteLine("4 - d10  (desetistěnná)");
        Console.WriteLine("5 - d12  (dvanáctistěnná)");
        Console.WriteLine("6 - d20  (dvacetistěná)");
        Console.WriteLine("\n0 - Konec");
        Console.Write("\nVaše volba: ");
    }

    static int GetSides(string input)
    {
        int[] sides = { 4, 6, 8, 10, 12, 20 };

        if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 6)
            return sides[choice - 1];

        return -1;
    }

    static int RollDice(int sides)
    {
        return random.Next(1, sides + 1);
    }

    static void CheckCritical(int result)
    {
        if (result == 20)
            Console.WriteLine("KRITICKÝ ÚSPĚCH!");
        else if (result == 1)
            Console.WriteLine("KRITICKÝ NEÚSPĚCH!");
    }
}
