using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Name Price
            //OutFall 4                   $39.99
            //CS: OG                      $15.99
            //Zplinter Zell	              $19.99
            //Honored 2                   $59.99
            //RoverWatch                  $29.99
            //RoverWatch Origins Edition  $39.99

            double currentBalance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double spentMoney = 0.0;

            while (input != "Game Time")
            {
                double gamePrice = 0.0;
                switch (input)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not found");
                        input = Console.ReadLine();
                        continue;
                }
                if (gamePrice <= currentBalance)
                {
                    currentBalance -= gamePrice;
                    Console.WriteLine($"Bought {input}");
                    spentMoney += gamePrice;
                    if (currentBalance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spentMoney:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
