using System;

namespace new_house
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeFlower = Console.ReadLine();
            var flowers = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());
            var finalPrice = 0.0;
            switch (typeFlower)
            {
                case "Roses":
                    finalPrice = 5.00 * flowers;
                    if (flowers > 80)
                    {
                        finalPrice = 0.90 * finalPrice;
                    }
                    break;
                case "Dahlias":
                    finalPrice = 3.80 * flowers;
                    if (flowers > 90)
                    {
                        finalPrice = 0.85 * finalPrice;
                    }
                    break;
                case "Tulips":
                    finalPrice = 2.80 * flowers;
                    if (flowers > 80)
                    {
                        finalPrice = 0.85 * finalPrice;
                    }
                    break;
                case "Narcissus":
                    finalPrice = 3.00 * flowers;
                    if (flowers < 120)
                    {
                        finalPrice = finalPrice + finalPrice * 0.15;
                    }
                    break;
                case "Gladiolus":
                    finalPrice = 2.50 * flowers;
                    if (flowers < 80)
                    {
                        finalPrice = finalPrice + finalPrice * 0.20;
                    }
                    break;
            }
            if (budget >= finalPrice)
            {
                var moneyLeft = Math.Abs(budget - finalPrice);
                Console.WriteLine($"Hey, you have a great garden with {flowers} {typeFlower} and {moneyLeft:f2} leva left.");
            }
            else
            {
                var neededMoney = Math.Abs(budget - finalPrice);
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }
        }
    }
}
