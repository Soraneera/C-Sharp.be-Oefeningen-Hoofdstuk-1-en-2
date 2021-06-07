using System;

namespace _2_12_Kassa
{
    class Program
    {
        static void Main(string[] args)
        {
            //background color
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            //variables Naam kassier, aantal strips, prijs per strip ex btw, Sum ex btw, btw tarief,btw bedrag en totaal in btw.
            decimal AS, SumEx, B, Sum;

            //obtaining variables
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Wat is je naam?: ");
            var N = Console.ReadLine();

            Console.WriteLine("Geet het aantal strips in: ");
            AS = Convert.ToDecimal(Console.ReadLine());

            //calculations
            SumEx = 5 * AS;
            B = (SumEx / 100) * 6;
            Sum = SumEx + B;
            
            //result 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("##############################");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("U wordt geholpen door {0}", N);
            Console.WriteLine("");
            Console.WriteLine("Eenheidsprijs exclusief BTW = 5 EUR");
            Console.WriteLine("Aantal = {0}", AS);
            Console.WriteLine("");
            Console.WriteLine("Subtotaal exclusief BTW = {0} EUR", SumEx);
            Console.WriteLine("");
            Console.WriteLine("BTW-tarief = 6 %");
            Console.WriteLine("BTW bedrag = {0} EUR", B);
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Totaal inclusief BTW = {0} EUR", Sum);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
