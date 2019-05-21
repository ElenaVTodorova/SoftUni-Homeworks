using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double priceForLightsabers = lightsaberPrice * Math.Ceiling(numberOfStudents * 1.1);
            double priceForRobes = robePrice * numberOfStudents;
            double priceForBelts = beltPrice * (numberOfStudents - numberOfStudents / 6);

            double totalPrice = priceForLightsabers + priceForRobes + priceForBelts;

            double diff = amount - totalPrice;
            if (diff>=0)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(diff):F2}lv more.");
            }

        }
    }
}
