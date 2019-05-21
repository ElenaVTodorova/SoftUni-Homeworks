using System;
using System.Collections.Generic;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = new List<char>();
            letters.Add(' ');

            for (char i = 'a'; i <= 'z'; i++)
            {
                letters.Add(i);
            }

            string sms = string.Empty;

            int numberOfRows = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRows; i++)
            {
                string currentRow = Console.ReadLine();
                int letterIndex = 0;
                int mainDigit = int.Parse(currentRow[0].ToString());
                if (mainDigit > 0)
                {
                    int offset = (mainDigit - 2) * 3;

                    if (mainDigit == 8 || mainDigit == 9)
                    {
                        offset++;
                    }
                    letterIndex = offset + currentRow.Length;
                }
                sms += letters[letterIndex];
            }
            Console.WriteLine(sms);
        }
    }
}
