using System;

namespace Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volume=int.Parse(Console.ReadLine());
            int flowP1=int.Parse(Console.ReadLine());
            int flowP2=int.Parse(Console.ReadLine());
            double hours=double.Parse(Console.ReadLine());

            double littersP1 = flowP1 * hours;
            double littersP2 = flowP2 * hours;
            double littersTotal = littersP1 + littersP2;

            if (littersTotal<volume)
            {
                double fulnessPoll=littersTotal/volume*100;
                double percentileP1 = (littersP1 / littersTotal * 100);
                double percentileP2=(littersP2/littersTotal*100);
               


                Console.WriteLine($"The pool is {fulnessPoll}% full. Pipe 1: {percentileP1}%. Pipe 2: {percentileP2}%.");
            }
            else
            {   
                double littersMore=littersTotal-volume;
                Console.WriteLine($"For {hours} hours the pool overflows with {littersMore} liters.");
            }
        }
    }
}
