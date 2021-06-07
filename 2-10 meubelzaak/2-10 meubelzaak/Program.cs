using System;

namespace _2_10_meubelzaak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double IN, Sum;

            //Obtaining Variables
            Console.Write("Geef inkoop prijs: ");
            IN = Convert.ToInt64(Console.ReadLine());

            //calculation
            Sum = (IN / 100) * 190 + IN;

            //result
            Console.WriteLine("");
            Console.WriteLine("Inkoop Prijs = {0}", IN);
            Console.WriteLine("Winstmarge = 190%");
            Console.WriteLine("Verkoop Prijs = {0}", Sum);

        }
    }
}
