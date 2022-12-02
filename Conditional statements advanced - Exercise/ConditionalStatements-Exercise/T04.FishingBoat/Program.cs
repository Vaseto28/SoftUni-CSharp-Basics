using System;

namespace fishing_boat
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var fishermen = int.Parse(Console.ReadLine());
            var finalPrice = 0.0;
            switch (season)
            {
                case "Spring":
                    finalPrice = 3000;
                    if (fishermen <= 6)
                    {
                        finalPrice *= 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        finalPrice *= 0.85;
                    }
                    else if (fishermen >= 12)
                    {
                        finalPrice *= 0.75;
                    }
                    if (fishermen % 2 == 0)
                    {
                        finalPrice = finalPrice - 0.05 * finalPrice;
                    }
                    break;
                case "Summer":
                    finalPrice = 4200;
                    if (fishermen <= 6)
                    {
                        finalPrice *= 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        finalPrice *= 0.85;
                    }
                    else if (fishermen >= 12)
                    {
                        finalPrice *= 0.75;
                    }
                    if (fishermen % 2 == 0)
                    {
                        finalPrice = finalPrice - 0.05 * finalPrice;
                    }
                    break;
                case "Autumn":
                    finalPrice = 4200;
                    if (fishermen <= 6)
                    {
                        finalPrice *= 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        finalPrice *= 0.85;
                    }
                    else if (fishermen >= 12)
                    {
                        finalPrice *= 0.75;
                    }
                    break;
                case "Winter":
                    finalPrice = 2600;
                    if (fishermen <= 6)
                    {
                        finalPrice *= 0.90;
                    }
                    else if (fishermen >= 7 && fishermen <= 11)
                    {
                        finalPrice *= 0.85;
                    }
                    else if (fishermen >= 12)
                    {
                        finalPrice *= 0.75;
                    }
                    if (fishermen % 2 == 0)
                    {
                        finalPrice = finalPrice - 0.05 * finalPrice;
                    }
                    break;
            }
            if (budget >= finalPrice)
            {
                var moneyLeft = Math.Abs(budget - finalPrice);
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                var neededMoney = Math.Abs(budget - finalPrice);
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
            }
        }
    }
}
