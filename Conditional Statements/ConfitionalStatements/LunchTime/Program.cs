using System;
using System.Diagnostics;

namespace LunchTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int durationMovie=int.Parse(Console.ReadLine());
            int durationBreak=int.Parse(Console.ReadLine());
            double num = 1.0 / 8.0;
            double num1 = 1.0 / 4.0;

            double timeLunch = durationBreak * num;
            double timeRelax = durationBreak * num1;
            double timeLeft = durationBreak - timeLunch-timeRelax; 
            

            if (timeLeft > durationMovie)
            {
                double time = timeLeft - durationMovie;
                Console.WriteLine ($"You have enougth time to watch {name} and left with {time} free time");     
            }
            else                     
            {
                double timeNeded = durationMovie-timeLeft;
                Console.WriteLine($"You do not enougth time to watch {name} and needed {timeNeded} free time");
            }
        }  
    }
}
