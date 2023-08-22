using System;

namespace Bonus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number=int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (number <= 0)
            {
                bonus = 5;
            }
            else if (number < 1000) 
            {
                bonus = number * 0.1;
            }
            else
            {
                bonus = number * 0.2;
            }
        }
    }
}
