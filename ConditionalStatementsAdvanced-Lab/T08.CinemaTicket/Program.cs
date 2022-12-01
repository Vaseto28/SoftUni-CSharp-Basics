using System;

namespace cinema_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayFromWeek = Console.ReadLine();
            var ticketPrice = 0;
            switch (dayFromWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    ticketPrice = 12;
                    break;
                case "Wednesday":
                case "Thursday":
                    ticketPrice = 14;
                    break;
                case "Saturday":
                case "Sunday":
                    ticketPrice = 16;
                    break;
            }
            Console.WriteLine(ticketPrice);
        }
    }
}
