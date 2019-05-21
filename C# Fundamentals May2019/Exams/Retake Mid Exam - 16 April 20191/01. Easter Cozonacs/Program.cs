using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());

            double eggsPrice = 0.75 * flourPrice;
            double milkPrice = 1.25 * flourPrice / 4;
            double priceForOneCozonac = flourPrice + eggsPrice + milkPrice;
            int cozonacs = 0;
            int coloredEggs = 0;

            while (budget >= priceForOneCozonac)
            {
                budget -= priceForOneCozonac;
                cozonacs++;
                coloredEggs += 3;
                if (cozonacs % 3 == 0)
                {
                    coloredEggs -= (cozonacs - 2);
                }
            }
            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {coloredEggs} eggs and {budget:F2}BGN left.");
        }
    }
}
