using System;

namespace deposit_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var deposit = double.Parse(Console.ReadLine());
            var period = int.Parse(Console.ReadLine());
            var lihvenprocent = double.Parse(Console.ReadLine());
            var suma = deposit + period * ((deposit * (lihvenprocent / 100)) / 12);
            Console.WriteLine(suma);
        }
    }
}
