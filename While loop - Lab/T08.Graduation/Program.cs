using System;

namespace graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var year = 1;
            var excluded = 0;
            var averageGrade = 0.0;
            while (year <= 12)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    excluded++;
                    if (excluded > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {year} grade");
                        break;
                    }
                    continue;
                }
                averageGrade += grade;
                year++;
            }
            if (year > 12)
            {
                averageGrade = averageGrade / 12;
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
            }
        }
    }
}
