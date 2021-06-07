using System;

namespace oefening_2_7_Y_berekenen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int Y, A, B, C;

            //Getting Variables
            Console.WriteLine("Geef waarde voor A: ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geef waarde voor B: ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geef waarde voor C: ");
            C = Convert.ToInt32(Console.ReadLine());

            //Calculation
            Y = A * (B / C);

            //Result
            Console.WriteLine("{0} * ({1} / {2}) = {3}", A, B, C, Y);
            Console.ReadLine();
        }
    }
}
