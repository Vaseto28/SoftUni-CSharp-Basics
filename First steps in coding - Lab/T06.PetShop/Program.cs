using System;

namespace petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = int.Parse(Console.ReadLine());
            var cats = int.Parse(Console.ReadLine());
            var price = dogs * 2.50 + cats * 4;
            Console.WriteLine(price + " lv.");
        }
    }
}
