using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var p4 = 0.0;
            var p5 = 0.0;
            for (int i = 1; i <= count; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    p1++;
                    //p1 = p1 / count * 100;
                }
                else if (number <= 399)
                {
                    p2++;
                    //p2 = p2 / count * 100;
                }
                else if (number <= 599)
                {
                    p3++;
                    //p3 = p3 / number * 100;
                }
                else if (number <= 799)
                {
                    p4++;
                    //p4 = p4 / number * 100;
                }
                else
                {
                    p5++;
                    //p5 = p5 / number * 100;
                }
            }

            p1 = p1 / count * 100;
            p2 = p2 / count * 100;
            p3 = p3 / count * 100;
            p4 = p4 / count * 100;
            p5 = p5 / count * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
