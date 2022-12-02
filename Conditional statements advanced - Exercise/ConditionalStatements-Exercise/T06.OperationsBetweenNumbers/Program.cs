using System;

namespace operrations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var operation = char.Parse(Console.ReadLine());
            var result = 0.0;
            string evenOrOdd;
            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (operation == '+')
                {
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd}");
                }
                if (operation == '-')
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd}");
                }
                if (operation == '*')
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }
                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd}");
                }
            }
            else if (n2 == 0)
            {
                Console.WriteLine($"Cannot divide {n1} by zero");
            }
            else if (operation == '/' || operation == '%')
            {
                if (operation == '/')
                {
                    result = 1.0 * n1 / n2;
                    Console.WriteLine($"{n1} {operation} {n2} = {result:f2}");
                }
                if (operation == '%')
                {
                    result = 1.0 * n1 % n2;
                    Console.WriteLine($"{n1} {operation} {n2} = {result}");
                }
            }
        }
    }
}
