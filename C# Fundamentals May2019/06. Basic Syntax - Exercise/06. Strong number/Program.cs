using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int currentNumber = number;
            int sumOfFactorials = 0;
            while (currentNumber != 0)
            {
                int lastDigit = currentNumber % 10;
                int factorial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    factorial *= i;
                }
                sumOfFactorials += factorial;
                currentNumber /= 10;
            }
            if (sumOfFactorials==number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
           
        }
    }
}
