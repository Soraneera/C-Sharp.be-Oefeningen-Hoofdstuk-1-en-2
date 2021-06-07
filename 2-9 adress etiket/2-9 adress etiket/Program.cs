using System;

namespace _2_9_adress_etiket
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console Colors
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //obtaining variables
            Console.Write("Voornaam: ");
            var V = Console.ReadLine();

            Console.Write("Achternaam: ");
            var A = Console.ReadLine();

            Console.Write("Straat: ");
            var S = Console.ReadLine();

            Console.Write("Huisnummer: ");
            var HN = Console.ReadLine();

            Console.Write("Postcode: ");
            var PC = Console.ReadLine();

            Console.Write("Gemeente: ");
            var G = Console.ReadLine();

            //etiket printen
            Console.WriteLine("");
            Console.WriteLine("####################");
            Console.WriteLine("{0} {1}", V, A);
            Console.WriteLine("{0} {1}", S, HN);
            Console.WriteLine("");
            Console.WriteLine("{0} {1}", PC, G);
            Console.WriteLine("####################");
            Console.WriteLine("");


        }
    }
}
