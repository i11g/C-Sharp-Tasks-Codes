using System;

namespace Shoping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            int video=int.Parse(Console.ReadLine());
            int procesors=int.Parse(Console.ReadLine());
            int memory=int.Parse(Console.ReadLine());

            double sumVideo = video * 250;
            double sum = sumVideo + (sumVideo * 0.35) + (sumVideo * 0.10);
            if (video>procesors)
            {
                sum = sum - (sum * 0.15);
            }

           if (budget>sum)
            {
                double budgetLeft = budget-sum;
                Console.WriteLine($"You have {budgetLeft:F2} leva left");
            }
           else
            {
                double sumNeeded = sum - budget;
                Console.WriteLine($"No money left. Yo need {sumNeeded:F2} leva");
            }
        }
    }
}
