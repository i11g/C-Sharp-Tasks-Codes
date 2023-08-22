using System;

namespace Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolii=int.Parse(Console.ReadLine());
            int zumbuls=int.Parse(Console.ReadLine());
            int roses=int.Parse(Console.ReadLine());
            int cactus=int.Parse(Console.ReadLine());
            double price=double.Parse(Console.ReadLine());

            double sum = magnolii * 3.25 + zumbuls * 4.00 + roses * 3.50 + cactus * 8.00;
            double totalsum = sum - sum * 0.05;
            if (totalsum <price )
            { 
                double diff=Math.Ceiling(price-totalsum);
                Console.WriteLine($"She will have to borrow {diff} leva.");

            }
            else
            {
                double diff = Math.Floor(totalsum-price);
                Console.WriteLine($"She is left with {diff} leva.");

            }
        }
    }
}
