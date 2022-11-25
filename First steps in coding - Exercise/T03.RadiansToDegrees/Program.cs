using System;

namespace radians_to_degreeses
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            var degreeses = radians * (180 / Math.PI);
            Console.WriteLine(degreeses);
        }
    }
}
