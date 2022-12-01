using System;

namespace fruit_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var dayOfWeek = Console.ReadLine();
            var vallue = double.Parse(Console.ReadLine());
            var fruitPrice = 0.0;
            var totalPrice = 0.0;
            bool isValid = true;
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana":
                            fruitPrice = 2.50;
                            break;
                        case "apple":
                            fruitPrice = 1.20;
                            break;
                        case "orange":
                            fruitPrice = 0.85;
                            break;
                        case "grapefruit":
                            fruitPrice = 1.45;
                            break;
                        case "kiwi":
                            fruitPrice = 2.70;
                            break;
                        case "pineapple":
                            fruitPrice = 5.50;
                            break;
                        case "grapes":
                            fruitPrice = 3.85;
                            break;
                        default:
                            isValid = false;
                            break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana":
                            fruitPrice = 2.70;
                            break;
                        case "apple":
                            fruitPrice = 1.25;
                            break;
                        case "orange":
                            fruitPrice = 0.90;
                            break;
                        case "grapefruit":
                            fruitPrice = 1.60;
                            break;
                        case "kiwi":
                            fruitPrice = 3.00;
                            break;
                        case "pineapple":
                            fruitPrice = 5.60;
                            break;
                        case "grapes":
                            fruitPrice = 4.20;
                            break;
                        default:
                            isValid = false;
                            break;
                    }
                    break;
                default:
                    isValid = false;
                    break;
            }
            totalPrice = fruitPrice * vallue;
            if (isValid == false)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}
