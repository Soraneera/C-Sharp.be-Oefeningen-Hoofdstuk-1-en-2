using System;

namespace Mercedes_dealer
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double Mer, EX, VAT;
            
            //getting variables
            Console.WriteLine("Prijs inclusief btw: ");
            Mer = Convert.ToInt64(Console.ReadLine().Replace(".",""));

            //calculation
            VAT = (Mer / 100) * 21;
            EX = Mer - VAT;

            //result
            var SumString = EX + "";
            var OutString = "";

            while (SumString.Length > 3)
            {
                OutString = "." + SumString.Substring(SumString.Length - 3) + OutString;
                SumString = SumString.Substring(0, SumString.Length - 3);
            }
            OutString = SumString + OutString;
            Console.Write("De prijs exclusief BTW bedraagt: " + OutString);

        }
    }
}
