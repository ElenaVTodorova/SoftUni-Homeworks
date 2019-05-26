using System;

namespace _01._Cooking_Masterclass
{
    class Program
    {
        static void Main(string[] args)
        {
            //            •	budget – floating - point number in range[0.00…1, 000.00]
            //•	students – integer in range[0…100]
            //•	price of flour for a package – floating - point number in range[0.00…100.00]
            //•	price of egg for a single egg – floating - point number in range[0.00…100.00]
            //•	price of apron for a single apron – floating - point number in range[0.00…100.00]

            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPriceForPackage = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double numberOfAprons = Math.Ceiling(1.2 * students);
            double totalPriceForAprons = numberOfAprons * apronPrice;
            int numberOfEggs = 10 * students;
            double totalPriceForEggs = numberOfEggs * eggPrice;
            int freePackegesOfFlour = students / 5;
            int numberOfFlourPackeges = students;
            double totalPriceFirFlour = (numberOfFlourPackeges - freePackegesOfFlour) * flourPriceForPackage;

            double finalPrice = totalPriceFirFlour + totalPriceForEggs + totalPriceForAprons;

            double diff = budget - finalPrice;

            if (diff >= 0)
            {
                Console.WriteLine($"Items purchased for {finalPrice:F2}$.");
            }
            else
            {
                diff = Math.Abs(diff);
                Console.WriteLine($"{diff:F2}$ more needed.");
            }
        }
    }
}
