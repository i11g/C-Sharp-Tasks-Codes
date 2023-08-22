using System;

namespace Sleepy_Cat_Tom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHolidays = int.Parse(Console.ReadLine());

            int playTime = ((365 - numberOfHolidays) * 63) + (numberOfHolidays * 127);

            if (playTime<= 30000)
            {
                int diff = 30000 - playTime;
                int diffHours = diff / 60;
                int diffMin = diff % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{diffHours} hours and {diffMin} minutes less for play");
            }
            else
            {

                int diff = playTime - 30000;
                int diffHours = diff / 60;
                int diffMin = diff % 60;

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{diffHours} hours and {diffMin} minutes more for play");
            }
        }
    }
}
