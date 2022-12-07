using System;

namespace sum_of_two_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var intervalStart = int.Parse(Console.ReadLine());
            var intervalEnd = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int firstNumber = intervalStart; firstNumber <= intervalEnd; firstNumber++)
            {
                for (int secondNumber = intervalStart; secondNumber <= intervalEnd; secondNumber++)
                {
                    var sum = firstNumber + secondNumber;
                    counter++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({firstNumber} + {secondNumber} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
