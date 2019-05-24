using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfElevator = int.Parse(Console.ReadLine());
            //int courses = (int)Math.Ceiling((double)numberOfPeople / capacityOfElevator);
            int courses = numberOfPeople / capacityOfElevator;
            if (numberOfPeople % capacityOfElevator != 0)
            {
                courses += 1;
            }
            Console.WriteLine(courses);
        }
    }
}
