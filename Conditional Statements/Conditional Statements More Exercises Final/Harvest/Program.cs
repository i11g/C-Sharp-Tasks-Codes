using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area=int.Parse(Console.ReadLine());
            double kilograms=double.Parse(Console.ReadLine());
            int litersNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double kilogramsVin = area * 0.4 * kilograms;
            double littersVin = kilogramsVin / 2.5;

            if (littersVin<litersNeeded)
            {
                double diff=Math.Floor(litersNeeded - littersVin);
                Console.WriteLine($"It will be a tough winter! More {diff} liters wine needed.");
            }
            else
            {   
                double diff=Math.Ceiling(littersVin- litersNeeded);
                double perWorker = Math.Ceiling(diff / workers);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(littersVin)} liters.");
                Console.WriteLine($"{diff} liters left -> {perWorker} liters per person.");

            }
        }
    }
}
