using System;

namespace _01._Christmas_Spirit
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int christmasSpirit = 0;
            int ornamentSetPrice = 2;
            int treeSkirtPrice = 5;
            int treeGarlandsPrice = 3;
            int treeLightsPrice = 15;

            int totalCost = 0;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                if (currentDay % 11 == 0)
                {
                    quantity += 2;
                }
                if (currentDay % 2 == 0)
                {
                    totalCost += quantity * ornamentSetPrice;
                    christmasSpirit += 5;
                }
                if (currentDay % 3 == 0)
                {
                    totalCost += (quantity * (treeSkirtPrice + treeGarlandsPrice));
                    christmasSpirit += 13;
                }
                if (currentDay % 5 == 0)
                {
                    totalCost += quantity * treeLightsPrice;
                    christmasSpirit += 17;
                    if (currentDay % 3 == 0)
                    {
                        christmasSpirit += 30;
                    }
                }
                if (currentDay % 10 == 0)
                {
                    totalCost += treeLightsPrice + treeGarlandsPrice + treeSkirtPrice;
                    christmasSpirit -= 20;
                    //quantity += 2;
                    if (currentDay == days)
                    {
                        christmasSpirit -= 30;
                    }
                }
            }
            Console.WriteLine($"Total cost: {totalCost}");
            Console.WriteLine($"Total spirit: {christmasSpirit}");
        }
    }
}
