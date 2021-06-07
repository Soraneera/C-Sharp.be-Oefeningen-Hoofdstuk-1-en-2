using System;

namespace _2_11_Maandwedde
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double I, Sum;

            //obtaining variables
            Console.Write("Inkomste deze maand: ");
            I = Convert.ToDouble(Console.ReadLine());

            //calculation
            Sum = (I / 100) * 8.25 + 958.36;

            //result
            Console.WriteLine("");
            Console.WriteLine("Maandwedde: {0}", Sum);

        }
    }
}
