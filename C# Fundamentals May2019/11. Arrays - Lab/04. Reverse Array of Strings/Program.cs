using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings = Console.ReadLine().Split();

            for (int i = 0; i < arrayOfStrings.Length / 2; i++)
            {
                string oldElement = arrayOfStrings[i];
                arrayOfStrings[i] = arrayOfStrings[arrayOfStrings.Length - 1 - i];
                arrayOfStrings[arrayOfStrings.Length - 1 - i] = oldElement;
            }

            Console.WriteLine(string.Join(" ", arrayOfStrings));
        }
    }
}
