using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            double priceForFuelPerKilometer = double.Parse(Console.ReadLine());
            double foodExpensesPerPersonPerDay = double.Parse(Console.ReadLine());
            double priceForHotelForNightPerPerson = double.Parse(Console.ReadLine());

            double totalPriceForHotel = priceForHotelForNightPerPerson * numberOfPeople * daysOfTrip;
            if (numberOfPeople > 10)
            {
                totalPriceForHotel *= 0.75;
            }
            double totalFoodExpenses = foodExpensesPerPersonPerDay * daysOfTrip * numberOfPeople;
            double currentExpenses = totalPriceForHotel + totalFoodExpenses;

            for (int currentDay = 1; currentDay <= daysOfTrip; currentDay++)
            {
                double distancePerDay = double.Parse(Console.ReadLine());
                double priceForFuel = priceForFuelPerKilometer * distancePerDay;
                currentExpenses += priceForFuel;
                if (currentDay % 3 == 0 || currentDay % 5 == 0)
                {
                    currentExpenses += currentExpenses * 0.4;
                }
                if (currentDay % 7 == 0)
                {
                    currentExpenses -= currentExpenses / numberOfPeople;
                }
                if (currentExpenses > budget)
                {
                    double diff = currentExpenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {diff:F2}$ more.");
                    return;
                }
            }
            Console.WriteLine($"You have reached the destination. You have {(budget - currentExpenses):F2}$ budget left.");
        }
    }
}
