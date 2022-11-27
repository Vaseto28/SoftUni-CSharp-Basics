using System;

namespace basketball_equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var tax = int.Parse(Console.ReadLine());
            var shoes = tax - 0.40 * tax;
            var clothes = shoes - 0.20 * shoes;
            var ball = 0.25 * clothes;
            var accessories = 0.20 * ball;
            var finalprice = shoes + clothes + ball + accessories + tax;
            Console.WriteLine(finalprice);
        }
    }
}
