using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var places = rows * columns;
            var price = 0.0;
            switch (type)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;
                default:
                    break;
            }
            var finalPrice = price * places;
            Console.WriteLine($"{finalPrice:f2} leva");
        }
    }
}
