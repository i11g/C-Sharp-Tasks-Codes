using System;

namespace Time_15_min_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hours=int.Parse(Console.ReadLine());
           int minutes=int.Parse(Console.ReadLine());

            int minutesPlusfifteenth = hours * 60 + minutes + 15;

            hours=minutesPlusfifteenth/60;
            minutes=minutesPlusfifteenth%60;


            if (hours > 23) 
            {
                Console.WriteLine($"{ 0}:{minutes:D2}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
            

        }
    }
}
