using System;
using System.Text;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                sb.Append(Console.ReadLine());
            }
            string result = sb.ToString();
            Console.WriteLine(result);

            //char symbol1 = char.Parse(Console.ReadLine());
            //char symbol2 = char.Parse(Console.ReadLine());
            //char symbol3 = char.Parse(Console.ReadLine());
            //string result = "" + symbol1 + symbol2 + symbol3;
            //Console.WriteLine(result);
        }
    }
}
