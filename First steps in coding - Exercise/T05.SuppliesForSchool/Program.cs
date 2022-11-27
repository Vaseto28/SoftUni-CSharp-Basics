using System;

namespace supplies_for_school
{
    class Program
    {
        static void Main(string[] args)
        {
            var pens = int.Parse(Console.ReadLine());
            var markers = int.Parse(Console.ReadLine());
            var preparat = int.Parse(Console.ReadLine());
            var procent = int.Parse(Console.ReadLine());
            var suma = pens * 5.8 + markers * 7.2 + preparat * 1.2;
            var finalPrice = suma - suma * procent / 100;
            Console.WriteLine(finalPrice);
        }
    }
}
