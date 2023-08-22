using System;

namespace Godzila
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double budget=double.Parse(Console.ReadLine());
           double workers=double.Parse(Console.ReadLine());
           double clothingPrice=double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double clothing = workers * clothingPrice;

            double budgetTotal = clothing + decor;
            
            if (workers>150)
            {
                budgetTotal = budgetTotal - clothing * 0.1;
            }
            
            if (budgetTotal>budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(budgetTotal-budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {Math.Abs(budgetTotal - budget):f2} leva left.");

            }
        }
    }
}
