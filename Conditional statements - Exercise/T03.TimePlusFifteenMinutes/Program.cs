using System;

namespace time___15_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalMinutes = hours * 60 + minutes;
            int hs = totalMinutes / 60;
            int mins = totalMinutes % 60 + 15;
            if (mins >= 60)
            {
                hs += 1;
                mins -= 60;
            }
            if (hs >= 24)
            {
                hs = hs - 24;
            }
            if (mins < 10)
            {
                Console.WriteLine($"{hs}:0{mins}");
            }
            else
            {
                Console.WriteLine($"{hs}:{mins}");
            }
        }
    }
}
