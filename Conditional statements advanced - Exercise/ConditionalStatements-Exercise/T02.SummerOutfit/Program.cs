using System;

namespace summer_outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var degreeses = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            switch (time)
            {
                case "Morning":
                    if (degreeses >= 10 && degreeses <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (degreeses > 18 && degreeses <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degreeses >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (degreeses >= 10 && degreeses <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (degreeses > 18 && degreeses <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (degreeses >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                default:
                    break;
            }
            Console.WriteLine($"It's {degreeses} degrees, get your {outfit} and {shoes}.");
        }
    }
}
