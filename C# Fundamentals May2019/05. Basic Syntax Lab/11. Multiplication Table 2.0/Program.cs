using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int multipier = int.Parse(Console.ReadLine());
            int startingNumber = int.Parse(Console.ReadLine());
            int product = 0;

            if (startingNumber <=10)
            {
                for (int times = startingNumber; times <= 10; times++)
                {
                    product = multipier * times;
                    Console.WriteLine($"{multipier} X {times} = {product}");
                }
            }
            else
            {
                product = multipier * startingNumber;
                Console.WriteLine($"{multipier} X {startingNumber} = {product}");
            }
        }
    }
}
