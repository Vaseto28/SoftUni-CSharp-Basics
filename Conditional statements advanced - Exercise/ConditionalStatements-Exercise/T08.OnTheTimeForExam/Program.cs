using System;

namespace on_time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var hourOfExam = int.Parse(Console.ReadLine());
            var minuteOfExam = int.Parse(Console.ReadLine());
            var hourOfArriving = int.Parse(Console.ReadLine());
            var minuteOfArriving = int.Parse(Console.ReadLine());
            var examMinutes = hourOfExam * 60 + minuteOfExam;
            var arrivingMinutes = hourOfArriving * 60 + minuteOfArriving;
            var earlier = arrivingMinutes + 30;
            var difference = examMinutes - arrivingMinutes;
            if (examMinutes == arrivingMinutes || difference >= 0 && difference <= 30)
            {
                if (difference <= 30)
                {
                    Console.WriteLine("On time");
                    if (difference == 0)
                    {

                    }
                    else
                    {
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                }
            }
            else if (examMinutes > earlier)
            {
                {
                    Console.WriteLine("Early");
                    if (difference <= 59)
                    {
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                    else
                    {
                        var hours = difference / 60;
                        var minutes = difference % 60;
                        if (minutes < 10)
                        {
                            Console.WriteLine($"{hours}:0{minutes} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{hours}:{minutes} hours before the start");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Late");
                difference = Math.Abs(difference);
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    var hours = difference / 60;
                    var minutes = difference % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{hours}:0{minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hours}:{minutes} hours after the start");
                    }
                }
            }
        }
    }
}
