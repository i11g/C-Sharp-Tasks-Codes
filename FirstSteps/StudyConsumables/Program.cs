using System;

namespace StudyConsumables
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfPencils=int.Parse(Console.ReadLine());
           int numberOfMarkers=int.Parse(Console.ReadLine());
           int litres=int.Parse(Console.ReadLine());
           int discount=int.Parse(Console.ReadLine());
            double price = (numberOfPencils * 5.80) + (numberOfMarkers * 7.20) + (litres * 1.20);
            double discountPrice = price * discount / 100;
            double finalPrice=price-discountPrice;
            Console.WriteLine(finalPrice);


        }
    }
}
