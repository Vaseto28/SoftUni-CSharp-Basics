using System;

namespace toy_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int value = puzzles + dolls + bears + minions + trucks;
            double price = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;
            if (value >= 50)
            {
                price = price - price * 0.25;
            }
            double finalPrice = price - price * 0.10;
            if (finalPrice >= neededMoney)
            {
                double moneyLeft = Math.Abs(neededMoney - finalPrice);
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                double neededMoreMoney = Math.Abs(neededMoney - finalPrice);
                Console.WriteLine($"Not enough money! {neededMoreMoney:f2} lv needed.");
            }
        }
    }
}
