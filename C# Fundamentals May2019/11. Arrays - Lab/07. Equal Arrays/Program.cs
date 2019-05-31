using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;
            int indexOfDifferentNumber = -1;
            bool isEqual = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    sum += firstArray[i];
                }
                else
                {
                    isEqual = false;
                    indexOfDifferentNumber = i;
                    break;
                }
            }
            if (isEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {indexOfDifferentNumber} index");
            }
        }
    }
}
