using System;

namespace ShopBabyToys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice=double.Parse(Console.ReadLine());
            int pazel=int.Parse(Console.ReadLine());
            int toys=int.Parse(Console.ReadLine());
            int bears=int.Parse(Console.ReadLine());
            int minuons=int.Parse(Console.ReadLine());
            int tracks=int.Parse(Console.ReadLine());

            double income = pazel * 2.60 + toys * 3 + bears * 4.10 + minuons * 8.20 + tracks * 2;
            int count = pazel + toys + bears + tracks + minuons;
            if (count>50) 
            {
                income = income - income * 0.25;
            }
            double rent = income * 0.1;
            double totalIncome = income - rent;

            if (totalIncome>=tripPrice)
            {
                double moneyLeft = totalIncome - tripPrice;
                Console.WriteLine($" Yes {moneyLeft} lv left");
            }
            else 
            {
                double moneyNedded = tripPrice - totalIncome;
                Console.WriteLine($"Not enough money! {moneyNedded:F2} lv nedded");
            }
        }
    }
}
