using System;
using System.Collections.Generic;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            bool isBaby = age >= 0 && age <= 2;
            bool isChild = age >= 3 && age <= 13;
            bool isTeenager = age >= 14 && age <= 19;
            bool isAdult = age >= 20 && age <= 65;
            bool isElder = age >= 66;
            if (isBaby)
            {
                Console.WriteLine("baby");
            }
            else if (isChild)
            {
                Console.WriteLine("child");
            }
            else if (isTeenager)
            {
                Console.WriteLine("teenager");
            }
            else if (isAdult)
            {
                Console.WriteLine("adult");

            }
            else if (isElder)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
