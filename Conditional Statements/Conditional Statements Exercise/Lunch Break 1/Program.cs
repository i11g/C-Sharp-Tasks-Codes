using System;

namespace Lunch_Break_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();

            int timeEpizod=int.Parse(Console.ReadLine());
            int timeBreak=int.Parse(Console.ReadLine());

            double timeActivities = (double)1 / 8 + (double)1 / 4;
            double timeLeft = timeBreak-timeBreak*timeActivities;

            if(timeLeft >= timeEpizod)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft - timeEpizod)} minutes free time.");
            }
            else if (timeLeft < timeEpizod) 
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(timeEpizod-timeLeft)} more minutes.");
            }
        }
    }
}
