using System;

namespace fish_tank
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());
            double volume = (lenght * width * height) * 0.001;
            var litres = volume - (percent / 100) * volume;
            Console.WriteLine(litres);
        }
    }
}
