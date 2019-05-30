using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] numbers = new int[range];

            for (int i = range - 1; i >= 0; i--)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            string result = string.Join(" ", numbers);
            Console.WriteLine(result);
        }
    }
}
