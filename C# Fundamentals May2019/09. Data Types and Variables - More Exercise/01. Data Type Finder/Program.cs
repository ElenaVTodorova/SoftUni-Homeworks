using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string dataType = string.Empty;
            int integer = 0;
            double floatingPoint;
            char character;
            bool isBool;
            while (input != "END")
            {
                if (int.TryParse(input, out integer))
                {
                    dataType = "integer";
                }
                else if (double.TryParse(input, out floatingPoint))
                {
                    dataType = "floating point";
                }
                else if (char.TryParse(input, out character))
                {
                    dataType = "character";
                }
                else if (bool.TryParse(input, out isBool))
                {
                    dataType = "boolean";
                }
                else
                {
                    dataType = "string";
                }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }
    }
}
