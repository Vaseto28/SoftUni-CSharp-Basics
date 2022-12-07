using System;

namespace train_the_trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var judges = int.Parse(Console.ReadLine());
            var nameOfThePresentation = Console.ReadLine();
            double grades;
            var averageGrade = 0.0;
            var averageGradesCounter = 0;
            while (nameOfThePresentation != "Finish")
            {
                var averageGradeOfTheStudent = 0.0;
                var gradesCounter = 0;
                var sumOfGrades = 0.0;
                for (int i = 1; i <= judges; i++)
                {
                    grades = double.Parse(Console.ReadLine());
                    gradesCounter++;
                    sumOfGrades += grades;
                }
                averageGradeOfTheStudent = sumOfGrades / gradesCounter;
                averageGrade += averageGradeOfTheStudent;
                averageGradesCounter++;
                Console.WriteLine($"{nameOfThePresentation} - {averageGradeOfTheStudent:f2}.");
                nameOfThePresentation = Console.ReadLine();
            }
            averageGrade = averageGrade / averageGradesCounter;
            Console.WriteLine($"Student's final assessment is {averageGrade:f2}.");
        }
    }
}
