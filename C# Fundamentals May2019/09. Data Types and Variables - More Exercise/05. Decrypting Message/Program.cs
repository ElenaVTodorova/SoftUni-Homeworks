using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());
            string decryptedMessage = string.Empty;

            for (int i = 0; i < numberOfLines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                char decryptedChar = (char)(character + key);
                decryptedMessage += decryptedChar;
            }
            
            Console.WriteLine(decryptedMessage);
        }
    }
}
