using System;

namespace _01._Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = 0;
            int coinsEarnedEveryday = 50;

            for (int currantDay = 1; currantDay <= days; currantDay++)
            {
                coins += 50;
                if (currantDay % 10 == 0)
                {
                    partySize -= 2;
                }
                if (currantDay % 15 == 0)
                {
                    partySize += 5;
                }
                if (currantDay % 3 == 0)
                {
                    coins -= partySize * 3;
                }
                if (currantDay % 5 == 0)
                {
                    coins += 20 * partySize;
                    if (currantDay % 3 == 0)
                    {
                        coins -= partySize * 2;
                    }
                }
                coins -= partySize * 2;
            }
            int coinsPerEachCampanion = coins / partySize;
            Console.WriteLine($"{partySize} companions received {coinsPerEachCampanion} coins each.");
        }
    }
}
