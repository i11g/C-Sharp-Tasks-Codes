using System;

namespace Shoping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            int numberVideo = int.Parse(Console.ReadLine());
            int procesors=int.Parse(Console.ReadLine());
            int ram=int.Parse(Console.ReadLine());

            double priceVideo = numberVideo * 250;
            double priceProcesors = (priceVideo * 0.35)*procesors;
            double priceRam = (priceVideo * 0.10)*ram;
            double total = priceVideo + priceProcesors + priceRam;
            if (numberVideo>procesors)
            {
                total = total - total * 0.15;
            }
            if(budget>=total)
            {
                double diff=budget-total;
                Console.WriteLine($"You have {diff:f2} leva left!");
            }
            else
            {
                double diff = total-budget;
                Console.WriteLine($"Not enough money! You need {diff:f2} leva more!");
            }
           
        }
    }
}
