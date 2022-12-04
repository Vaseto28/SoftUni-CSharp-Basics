using System;

namespace trekking_mania
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());
            var everyone = 0;
            var t1 = 0.0;
            var t2 = 0.0;
            var t3 = 0.0;
            var t4 = 0.0;
            var t5 = 0.0;
            for (int i = 0; i < groups; i++)
            {
                var trekkers = int.Parse(Console.ReadLine());
                if (trekkers <= 5)
                {
                    t1 += trekkers;
                }
                else if (trekkers <= 12)
                {
                    t2 += trekkers;
                }
                else if (trekkers <= 25)
                {
                    t3 += trekkers;
                }
                else if (trekkers <= 40)
                {
                    t4 += trekkers;
                }
                else
                {
                    t5 += trekkers;
                }
                everyone += trekkers;
            }
            t1 = t1 / everyone * 100;
            t2 = t2 / everyone * 100;
            t3 = t3 / everyone * 100;
            t4 = t4 / everyone * 100;
            t5 = t5 / everyone * 100;
            Console.WriteLine($"{t1:f2}%");
            Console.WriteLine($"{t2:f2}%");
            Console.WriteLine($"{t3:f2}%");
            Console.WriteLine($"{t4:f2}%");
            Console.WriteLine($"{t5:f2}%");
        }
    }
}
