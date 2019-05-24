using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPours = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int pouredLitters = 0;

            for (int i = 0; i < numberOfPours; i++)
            {
                int litterOfWater = int.Parse(Console.ReadLine());
                if (pouredLitters + litterOfWater <= tankCapacity)
                {
                    pouredLitters += litterOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(pouredLitters);
        }
    }
}
