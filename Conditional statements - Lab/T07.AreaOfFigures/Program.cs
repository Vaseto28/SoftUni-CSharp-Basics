using System;

namespace area_of_figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                var area = side * side;
                Console.WriteLine(area);
            }
            if (figure == "rectangle")
            {
                var lenght = double.Parse(Console.ReadLine());
                var width = double.Parse(Console.ReadLine());
                var area = lenght * width;
                Console.WriteLine(area);
            }
            if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                var area = radius * radius * Math.PI;
                Console.WriteLine(area);
            }
            if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                var area = (side * height) / 2;
                Console.WriteLine(area);
            }
        }
    }
}
