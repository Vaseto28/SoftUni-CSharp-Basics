using System;

namespace account_money
{
    class Program
    {
        static void Main(string[] args)
        {
            var comands = Console.ReadLine();
            var sum = 0.0;
            while (comands != "NoMoreMoney")
            {
                var amount = double.Parse(comands);
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += amount;
                Console.WriteLine($"Increase: {amount:f2}");
                comands = Console.ReadLine();
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
