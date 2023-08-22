using System;

namespace Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int foodLefT = int.Parse(Console.ReadLine());
            double foodDog = double.Parse(Console.ReadLine());
            double foodCat = double.Parse(Console.ReadLine());
            double foodTurtule = double.Parse(Console.ReadLine());

            double foodNeeded = numberOfDays * foodDog + numberOfDays * foodCat + (numberOfDays * foodTurtule / 1000);

            if (foodNeeded < foodLefT)
            {
                double diff = Math.Floor(foodLefT - foodNeeded);
                Console.WriteLine($"{diff} kilos of food left.");
            }
            else
            {
                double diff = Math.Ceiling(foodNeeded - foodLefT);
                Console.WriteLine($"{diff} more kilos of food are needed.");
            }
        }
    }
}
