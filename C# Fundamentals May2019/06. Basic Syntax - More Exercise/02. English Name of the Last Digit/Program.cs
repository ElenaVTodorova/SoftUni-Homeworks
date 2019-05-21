using System;
using System.Collections.Generic;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            numbers.Sort();
            numbers.Reverse();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
