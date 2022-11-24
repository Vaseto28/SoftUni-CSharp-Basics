using System;T

namespace inches_and_santimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            var santimeters = inches * 2.54;
            Console.WriteLine(santimeters);
        }
    }
}
