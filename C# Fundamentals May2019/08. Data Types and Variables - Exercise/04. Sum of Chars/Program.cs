using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());
            int sumOfChars = 0;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                sumOfChars += currentChar;
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
