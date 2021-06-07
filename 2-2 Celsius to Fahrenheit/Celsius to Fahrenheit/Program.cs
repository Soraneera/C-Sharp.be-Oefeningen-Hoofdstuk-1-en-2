using System;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            double F;
            double C;
            
           //Getting Celsius
            Console.Write("Geef temperatuur in graden Celsius: ");
            C = Convert.ToInt16(Console.ReadLine());

            //Calculating Celsius to Fahrenheit
            F = (C * 9) / 5 + 32;

            //Result
            Console.WriteLine("Een temperatuur van {0} graden Celsius kom overeen met {1} graden Fahrenheit", C, F);
           

        }
    }
}
