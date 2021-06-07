using System;

namespace _calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kleuren instellen
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            //Declaratie van de variabelen
            int intGetal1, intGetal2, intsom;

            //De 2 getallen opvragen
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Geef getal 1: ");
            intGetal1 = Convert.ToInt16(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Geef getal 2: ");
            intGetal2 = Convert.ToInt16(Console.ReadLine());

            //De som berekenen
            intsom = intGetal1 + intGetal2;

            //Het resultaat weergeven in de console
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("De som bedraagt "+ intsom.ToString());
            Console.ReadLine();
        }
    }
}
