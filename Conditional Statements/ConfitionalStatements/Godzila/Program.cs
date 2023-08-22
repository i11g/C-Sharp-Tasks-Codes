using System;

namespace Godzila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            double number=double.Parse(Console.ReadLine());
            double priceClothes=double.Parse(Console.ReadLine());

            double totalClothes = number * priceClothes;
            if (number > 150) 
            {
                totalClothes = totalClothes - totalClothes * 0.1;
            }
            double decor = budget * 0.1;

            double totalBudget = totalClothes + decor;
            if (totalBudget >=budget) 
            {
                double neddedMpney = totalBudget - budget;
                Console.WriteLine($"Not enougth money");
                Console.WriteLine($"Winger needs{neddedMpney:F2} lv");
            }
            else
            {
                double moneyLeft = budget - totalBudget;
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} lv");
            }
        }
    }
}
