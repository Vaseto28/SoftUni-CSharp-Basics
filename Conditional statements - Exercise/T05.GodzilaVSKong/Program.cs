using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForClothing = double.Parse(Console.ReadLine());
            double dekorPrice = budget * 0.10;
            double totalClothingPrice = statists * priceForClothing;
            if (statists > 150)
            {
                totalClothingPrice = totalClothingPrice - totalClothingPrice * 0.10;
            }
            double totalPrice = dekorPrice + totalClothingPrice;
            if (totalPrice > budget)
            {
                double neededMoney = Math.Abs(totalPrice - budget);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:f2} leva more.");
            }
            else
            {
                double moreMoney = Math.Abs(totalPrice - budget);
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moreMoney:f2} leva left.");
            }
        }
    }
}