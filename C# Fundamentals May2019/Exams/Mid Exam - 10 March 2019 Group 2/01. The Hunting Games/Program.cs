using System;

namespace _01._The_Hunting_Games
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPedDayForOnePerson = double.Parse(Console.ReadLine());
            double foodPedDayForOnePerson = double.Parse(Console.ReadLine());

            double currentWaterForAllGroup = waterPedDayForOnePerson * numberOfPlayers * daysOfAdventure;
            double currentFoodOfAllGroup = foodPedDayForOnePerson * numberOfPlayers * daysOfAdventure;

            for (int currentDay = 1; currentDay <= daysOfAdventure; currentDay++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                groupEnergy -= energyLoss;
                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {currentFoodOfAllGroup:F2} food and {currentWaterForAllGroup:F2} water.");
                    break;
                }
                if (currentDay % 2 == 0)
                {
                    groupEnergy *= 1.05;
                    currentWaterForAllGroup *= 0.7;
                }
                if (currentDay % 3 == 0)
                {
                    groupEnergy *= 1.10;
                    currentFoodOfAllGroup -= currentFoodOfAllGroup / numberOfPlayers;
                }
            }
            if (groupEnergy > 0)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
            }
        }
    }
}
