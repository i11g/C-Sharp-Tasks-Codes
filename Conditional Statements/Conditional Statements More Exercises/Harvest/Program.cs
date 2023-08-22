using System;

namespace Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area=int.Parse(Console.ReadLine());
            double kilograms=double.Parse(Console.ReadLine());
            int litters = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double harvest = area * kilograms*0.4;
            double littersWine = harvest / 2.5;

            if (littersWine <litters)
            {
                double difference=litters-littersWine;
                double differencePerWorkers = difference / workers;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(difference)} liters wine needed.");
            }
            else
            {
                double difference = littersWine- litters;
                double differencePerWorkers = difference / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(littersWine)} liters.");
                Console.WriteLine($"{difference} liters left -> {Math.Ceiling(differencePerWorkers)} liters per person.");
            }
        }
    }
}
