using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInMeters = double.Parse(Console.ReadLine());
            double distnaceInKilometers = distanceInMeters / 1000;
            Console.WriteLine($"{distnaceInKilometers:F2}");
        }
    }
}
