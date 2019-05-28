using System;

namespace _04._Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= lastNumber; currentNumber++)
            {
                bool isPrime = true;
                for (int i = 2; i < currentNumber; i++)
                {
                    if (currentNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{currentNumber} -> true");
                }
                else
                {
                    Console.WriteLine($"{currentNumber} -> false");
                }
                
            }

        }
    }
}
