using System;

namespace Ploperdeplop
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double VA, KA, V, K, Sum;  

            //obtaining variables
            Console.Write("Aantal kinderen tot 12 jaar: ");
            KA = Convert.ToInt64(Console.ReadLine());

            Console.Write("Aantal volwassenen: ");
            VA = Convert.ToInt64(Console.ReadLine());

            //Calculations
            K = KA * 10;
            V = VA * 25;

            Sum = K + V;

            //result
            Console.WriteLine("Kinderen onder de 12: {0}       {1} EUR", KA, K);
            Console.WriteLine("Volwassenen:          {0}       {1} EUR", VA, V);
            Console.WriteLine("Totaal:                       {0} EUR", Sum);

        }  
    }
}
