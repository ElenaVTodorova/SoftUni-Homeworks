using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int spiceConsumedPerDay = 26;
            int totalAmount = 0;
            int days = 0;
            int droppingYieldPerDay = 10;

            while (startingYield >= 100)
            {
                totalAmount += startingYield - spiceConsumedPerDay;
                startingYield -= droppingYieldPerDay;
                days++;
            }
            if (totalAmount > 0)
            {
                totalAmount -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(totalAmount);
        }
    }
}
