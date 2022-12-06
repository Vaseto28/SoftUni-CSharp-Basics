using System;

namespace exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var allowedPoorGrades = int.Parse(Console.ReadLine());
            var averageGrade = 0.0;
            var totalGrades = 0.0;
            var lastExamName = "";
            var failedExams = 0;
            var isFailed = false;
            var examCounter = 0;
            var examName = Console.ReadLine();
            while (examName != "Enough")
            {
                var examGrade = int.Parse(Console.ReadLine());
                examCounter++;
                if (examGrade <= 4)
                {
                    failedExams++;
                    if (failedExams >= allowedPoorGrades)
                    {
                        isFailed = true;
                        break;
                    }
                }
                totalGrades += examGrade;
                lastExamName = examName;
                examName = Console.ReadLine();
            }
            averageGrade = totalGrades / examCounter;
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedExams} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {examCounter}");
                Console.WriteLine($"Last problem: {lastExamName}");
            }
        }
    }
}
