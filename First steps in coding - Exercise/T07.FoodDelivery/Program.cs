using System;

namespace food_delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var chickenMenus = int.Parse(Console.ReadLine());
            var fishMenus = int.Parse(Console.ReadLine());
            var vegetableMenus = int.Parse(Console.ReadLine());
            var priceOfMenus = chickenMenus * 10.35 + fishMenus * 12.40 + vegetableMenus * 8.15;
            var finalprice = priceOfMenus + priceOfMenus * 0.20 + 2.50;
            Console.WriteLine(finalprice);
        }
    }
}
