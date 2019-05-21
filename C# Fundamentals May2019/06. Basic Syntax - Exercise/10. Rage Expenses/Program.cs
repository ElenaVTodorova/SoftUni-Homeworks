using System;

namespace ConsoleAp10._Rage_Expensesp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            
            double moneyForHeadsets = lostGames / 2 * headsetPrice;
            double moneyForMouses = lostGames / 3 * mousePrice;
            double moneyForKeyboards = lostGames / 6 * keyboardPrice;
            double moneyForDisplays = lostGames / 12 * displayPrice;

            double totalPrice = moneyForHeadsets + moneyForMouses + moneyForKeyboards + moneyForDisplays;

            Console.WriteLine($"Rage expenses: {totalPrice:F2} lv.");


        }
    }
}
