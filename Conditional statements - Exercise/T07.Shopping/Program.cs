using System;

namespace shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int RAMs = int.Parse(Console.ReadLine());
            double finalPrice = videoCards * 250 + processors * (0.35 * videoCards * 250) + RAMs * (0.10 * videoCards * 250);
            if (videoCards > processors)
            {
                finalPrice = finalPrice - finalPrice * 0.15;
            }
            if (finalPrice > budget)
            {
                double neededMoney = Math.Abs(finalPrice - budget);
                Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
            }
            else
            {
                double moneyLeft = Math.Abs(finalPrice - budget);
                Console.WriteLine($"You have {moneyLeft:f2} leva left!");
            }
        }
    }
}
