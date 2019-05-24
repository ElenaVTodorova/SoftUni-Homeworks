using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstChar = int.Parse(Console.ReadLine());
            int lastChar = int.Parse(Console.ReadLine());

            for (char currentChar = (char)firstChar; currentChar <= lastChar; currentChar++)
            {
                Console.Write(currentChar + " ");
            }
        }
    }
}
