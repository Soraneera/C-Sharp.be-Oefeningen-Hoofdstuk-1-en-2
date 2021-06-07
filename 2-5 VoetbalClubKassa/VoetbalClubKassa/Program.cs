using System;

namespace VoetbalClubKassa
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double F, K, I, D, FA, KA, IA, DA, Sum;

            //obtaining variables
            Console.Write("Aantal friet met mosselen: ");
            FA = Convert.ToInt64(Console.ReadLine());

            Console.Write("Aantal Koninginnehappjes: ");
            KA = Convert.ToInt64(Console.ReadLine());

            Console.Write("Aantal Ijsjes: ");
            IA = Convert.ToInt64(Console.ReadLine());

            Console.Write("Aantal Drankjes: ");
            DA = Convert.ToInt64(Console.ReadLine());

            //Calculations
            F = FA * 20;
            K = KA * 10;
            I = IA * 3;
            D = DA * 2;
            Sum = F + K + I + D;

            //result
            Console.Write("Het totaal te betalen bedrag is {0} EUR", Sum);
        }
    }
}
