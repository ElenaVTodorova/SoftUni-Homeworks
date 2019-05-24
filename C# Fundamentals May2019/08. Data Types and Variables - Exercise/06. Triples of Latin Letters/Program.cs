using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLetters = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a'+ numberOfLetters; i++)
            {
                for (char j = 'a'; j < 'a' + numberOfLetters; j++)
                {
                    for (char k = 'a'; k < 'a' + numberOfLetters; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
