using System;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int mins = 0; mins < 60; mins++)
                {
                    Console.WriteLine($"{hour}:{mins}");
                }
            }
        }
    }
}
