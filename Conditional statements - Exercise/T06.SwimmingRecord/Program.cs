using System;

namespace swimming_record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            double time = meters * speed;
            double delay = Math.Floor(meters / 15) * 12.5;
            double totalTime = time + delay;
            if (totalTime >= record)
            {
                double timeLeft = Math.Abs(record - totalTime);
                Console.WriteLine($"No, he failed! He was {timeLeft:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
        }
    }
}
