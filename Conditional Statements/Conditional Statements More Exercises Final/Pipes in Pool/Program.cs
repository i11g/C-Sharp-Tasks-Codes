using System;

namespace Pipes_in_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volume=int.Parse(Console.ReadLine());   
            int debitP1=int.Parse(Console.ReadLine());
            int debitP2=int.Parse(Console.ReadLine());
            double hours=double.Parse(Console.ReadLine());

            double volumePipes=debitP1*hours+debitP2*hours;
            if (volume>=volumePipes)
            {   
                double percentile=volumePipes/volume*100;
                double perecentileP1=debitP1*hours/volumePipes*100;
                double perecentileP2=debitP2*hours/volumePipes*100;
                Console.WriteLine($"The pool is {percentile:f2}% full. Pipe 1: {perecentileP1:f2}%. Pipe 2: {perecentileP2:f2}%.");
            }
            else
            {
                double diff= volumePipes - volume;
                Console.WriteLine($"For {hours} hours the pool overflows with {diff:f2} liters.");
            }
        }
    }
}
