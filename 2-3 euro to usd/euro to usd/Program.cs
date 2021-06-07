using System;

namespace euro_to_usd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double EU;
            double US;

            EU = 1.0000;
            US = 1.2231;

            //Obtaining variables
            Console.Write("Hoeveel EUR wilt u omzetten naar USD: ");
            EU = Convert.ToInt16(Console.ReadLine());

            //Calculation
            US = EU * US;

            //result
            Console.WriteLine("{0} EUR is gelijk aan {1} USD", EU, US);
        }
    }
}
