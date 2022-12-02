using System;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var finalPrice = 0.0;
            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        finalPrice = budget * 0.30;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        finalPrice = budget * 0.40;
                    }
                    else
                    {
                        finalPrice = budget * 0.90;
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        finalPrice = budget * 0.70;
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        finalPrice = budget * 0.80;
                    }
                    else
                    {
                        finalPrice = budget * 0.90;
                    }
                    break;
            }
            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {finalPrice:f2}");
                }
                else
                {
                    Console.WriteLine($"Hotel - {finalPrice:f2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {finalPrice:f2}");
                }
                else
                {
                    Console.WriteLine($"Hotel - {finalPrice:f2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {finalPrice:f2}");
            }
        }
    }
}
