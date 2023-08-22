using System;

namespace Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            double duration=int.Parse(Console.ReadLine());
            double breakDuration=int.Parse(Console.ReadLine());

            double time1 = 1.00 / 8.00;
            double linchTime =Math.Ceiling(breakDuration * time1);
            double time2 = 1.00 / 4.00;
            double recreationTime = Math.Ceiling(breakDuration * time2);
            double timeLeft = Math.Ceiling(breakDuration - linchTime - recreationTime);

            if (timeLeft >= duration)
            {
                double diff=Math.Ceiling(timeLeft - duration);
                Console.WriteLine($"You have enough time to watch {name} and left with {diff} minutes free time.");
            }
            else
            {
                double diff = Math.Ceiling(duration - timeLeft);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {diff} more minutes.");
            }
        }
        }
    }

