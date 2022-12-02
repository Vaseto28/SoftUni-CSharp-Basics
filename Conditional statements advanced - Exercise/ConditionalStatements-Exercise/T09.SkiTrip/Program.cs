using System;

namespace ski_trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var typeOfRoom = Console.ReadLine();
            var mark = Console.ReadLine();
            var totalPrice = 0.0;
            days = days - 1;
            switch (typeOfRoom)
            {
                case "room for one person":
                    totalPrice = days * 18.00;
                    break;
                case "apartment":
                    totalPrice = days * 25.00;
                    if (days < 10)
                    {
                        totalPrice = totalPrice - totalPrice * 0.30;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = totalPrice - totalPrice * 0.35;
                    }
                    else if (days > 15)
                    {
                        totalPrice = totalPrice - totalPrice * 0.50;
                    }
                    break;
                case "president apartment":
                    totalPrice = days * 35.00;
                    if (days < 10)
                    {
                        totalPrice = totalPrice - totalPrice * 0.10;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        totalPrice = totalPrice - totalPrice * 0.15;
                    }
                    else if (days > 15)
                    {
                        totalPrice = totalPrice - totalPrice * 0.20;
                    }
                    break;
            }
            switch (mark)
            {
                case "positive":
                    totalPrice = totalPrice + totalPrice * 0.25;
                    break;
                case "negative":
                    totalPrice = totalPrice - totalPrice * 0.10;
                    break;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
