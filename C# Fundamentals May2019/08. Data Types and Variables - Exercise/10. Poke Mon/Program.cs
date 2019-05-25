using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetsCount = 0;
            int currentPokePower = startingPokePower;
            

            while (currentPokePower >= distanceBetweenTargets)
            {
                currentPokePower -= distanceBetweenTargets;
                targetsCount++;
                bool isFifteenPercent = currentPokePower == 0.5*startingPokePower;
                if (isFifteenPercent && exhaustionFactor != 0)
                {
                    currentPokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(currentPokePower);
            Console.WriteLine(targetsCount);
        }
    }
}
