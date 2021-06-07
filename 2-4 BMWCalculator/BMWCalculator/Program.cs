using System;

namespace BMWCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables and values
            double BMW;
            double Sum;

            //getting variable BMW
            Console.Write("prijs exclusief BTW: ");
            BMW = Convert.ToInt64(Console.ReadLine().Replace(".", ""));

            //calculation
            Sum = (BMW / 100) * 21 + BMW;

            //result
            var SumString = Sum + "";
            var OutString = "";

            while (SumString.Length > 3)
            {
                OutString = "." + SumString.Substring(SumString.Length - 3) + OutString;
                SumString = SumString.Substring(0, SumString.Length - 3);
            }
            OutString = SumString + OutString;
            Console.Write("De prijs inclusief BTW bedraagt: " + OutString);
        }
    }
}