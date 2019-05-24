using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double biggestVolumeOfKeg = double.MinValue;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string modelOfCurrentKeg = Console.ReadLine();
                double radiusOfCurrentKeg = double.Parse(Console.ReadLine());
                int heightOfCurrentKeg = int.Parse(Console.ReadLine());

                double volumeOfKeg = Math.PI * radiusOfCurrentKeg * radiusOfCurrentKeg * heightOfCurrentKeg;

                if (volumeOfKeg > biggestVolumeOfKeg)
                {
                    biggestKeg = modelOfCurrentKeg;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
