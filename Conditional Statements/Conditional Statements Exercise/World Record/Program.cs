using System;

namespace World_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds=double.Parse(Console.ReadLine());
            double distabceMeters=double.Parse(Console.ReadLine());
            double timeForMeter=double.Parse(Console.ReadLine());

            double timeIvan = timeForMeter * distabceMeters;
            double resistance = Math.Floor(distabceMeters/15);
            if (resistance>0)
            {
                timeIvan = timeIvan + resistance * 12.5;
            }
            if (timeIvan>=recordSeconds)
            {
                double diff=timeIvan-recordSeconds;
                Console.WriteLine($"No, he failed! He was {diff:f2} seconds slower.");
            }
            if (timeIvan < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeIvan:f2} seconds. ");
            }
        }
    }
}
