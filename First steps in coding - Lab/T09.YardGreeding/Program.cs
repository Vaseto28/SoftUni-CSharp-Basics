using System;

namespace yard_greening
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var discount = (area * 7.61) * 0.18;
            var finalprice = (area * 7.61) - discount;
            Console.WriteLine("The final price is " + finalprice + " lv.");
            Console.WriteLine("The discount is " + discount + " lv.");
        }
    }
}
