using System;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice=double.Parse(Console.ReadLine());
            int numberPazels=int.Parse(Console.ReadLine());
            int numberDols=int.Parse(Console.ReadLine());
            int numberBears=int.Parse(Console.ReadLine());
            int numberminiond=int.Parse(Console.ReadLine());
            int numberTraks=int.Parse(Console.ReadLine());

            double total = numberPazels * 2.60 + numberDols * 3.00 + numberBears * 4.10 + numberminiond * 8.20 + numberTraks * 2.00;
            int totalToys = numberTraks + numberPazels + numberminiond + numberDols + numberBears;
             if (totalToys>=50)
            {
                total = total - total * 0.25;
            }

            total = total - total * 0.1;

            if (total>=tripPrice)
            {
                double diff = total - tripPrice;
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                double diff = tripPrice-total;
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");

            }
        }
    }
}
