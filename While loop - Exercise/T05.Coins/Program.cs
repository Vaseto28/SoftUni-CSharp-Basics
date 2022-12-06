using System;

namespace coins
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var coinCounter = 0;
            while (money > 0)
            {
                money = Math.Round(money, 2);
                if (money >= 2)
                {
                    money -= 2;
                    coinCounter++;
                }
                else if (money >= 1)
                {
                    money -= 1;
                    coinCounter++;
                }
                else if (money >= 0.50)
                {
                    money -= 0.50;
                    coinCounter++;
                }
                else if (money >= 0.20)
                {
                    money -= 0.20;
                    coinCounter++;
                }
                else if (money >= 0.10)
                {
                    money -= 0.10;
                    coinCounter++;
                }
                else if (money >= 0.05)
                {
                    money -= 0.05;
                    coinCounter++;
                }
                else if (money >= 0.02)
                {
                    money -= 0.02;
                    coinCounter++;
                }
                else
                {
                    money -= 0.01;
                    coinCounter++;
                }
            }
            Console.WriteLine(coinCounter);
        }
    }
}
