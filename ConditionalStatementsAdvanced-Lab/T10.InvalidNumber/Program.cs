using System;

namespace invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            bool isValid = number >= 100 && number <= 200 || number == 0;
            if (!isValid)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
