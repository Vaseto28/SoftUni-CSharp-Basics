using System;

namespace excellent_mark
{
    class Program
    {
        static void Main(string[] args)
        {
            var mark = double.Parse(Console.ReadLine());
            if (mark >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
