using System;

namespace WorldRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record=double.Parse(Console.ReadLine());
            double distanceMeters=double.Parse(Console.ReadLine());
            double timeSeconds=double.Parse(Console.ReadLine());

            double time=distanceMeters*timeSeconds;
            double resistanceNumber = distanceMeters / 15;
            double resistance = Math.Round((resistanceNumber * 12.5));
            double finalTime = time + resistance;

            if (record>finalTime)
            {
                Console.WriteLine($"Yes, he sucseed! The new recprd is {finalTime:F2}"); 

            }
            else
            {
                double seconds=finalTime - record;
                Console.WriteLine($"No he failed! He was {seconds:F2} seconds slower");
            }
        }
    }
}
