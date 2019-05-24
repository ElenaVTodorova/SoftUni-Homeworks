using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= lastNumber; currentNumber++)
            {
                int number = currentNumber;
                int sumOfDigits = 0;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number /= 10;
                }
                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecial);
            }
        }
    }
}
