using System;

namespace Deposits
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double depositSum=double.Parse(Console.ReadLine());
            double depositTerms=double.Parse(Console.ReadLine());
            double interest=double.Parse(Console.ReadLine());

            double finalSum=depositSum+depositTerms*(((interest/100)*depositSum)/12);
            Console.WriteLine(finalSum);
            
        }
    }
}
