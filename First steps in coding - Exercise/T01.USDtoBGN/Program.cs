using System;

namespace USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            Console.WriteLine(BGN);
        }
    }
}
