using System;
using System.Linq;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int currentLine = 0; currentLine < numberOfLines; currentLine++)
            {
                long[] numbers = Console.ReadLine()
                    .Split()
                    .Select(long.Parse)
                    .ToArray();
                long maxNumber = Math.Max(numbers[0], numbers[1]);
                maxNumber = Math.Abs(maxNumber);
                long sumOfDigits = 0;
                while (maxNumber > 0)
                {
                    sumOfDigits += maxNumber % 10;
                    maxNumber /= 10;
                }
                Console.WriteLine(sumOfDigits);
            }
        }
    }
}
