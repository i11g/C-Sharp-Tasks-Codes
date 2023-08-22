using System;

namespace CurrencyConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double usd=double.Parse(Console.ReadLine());
            //Action
            double bgn = usd * 1.79549;
            //Outpui
            Console.WriteLine(bgn);

        }
    }
}
