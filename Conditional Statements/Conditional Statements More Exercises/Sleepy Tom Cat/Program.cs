using System;

namespace Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHolidays=int.Parse(Console.ReadLine());

            int numberOfWorkingDays = 365 - numberOfHolidays;
            int minutesForPlay = (numberOfWorkingDays * 63) + (numberOfHolidays * 127);

            if (minutesForPlay<30000) 
            {
                int minutesLessForPlay = 30000 - minutesForPlay;
                int hours=minutesLessForPlay/60;
                int minutes = minutesLessForPlay % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                int minutesMore = minutesForPlay-30000;
                int hours = minutesMore / 60;
                int minutes = minutesMore % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
