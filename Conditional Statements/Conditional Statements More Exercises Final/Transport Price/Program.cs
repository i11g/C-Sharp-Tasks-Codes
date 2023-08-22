using System;

namespace Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilomenters=int.Parse(Console.ReadLine());
            string time=Console.ReadLine();
            double price = 0;

            if(kilomenters<20&&kilomenters!=0&&time=="day")
            {
                price = kilomenters * 0.79 + 0.70;
            }
            else if (kilomenters<20&& kilomenters != 0&&time =="night")
            {
                price= kilomenters * 0.90 + 0.70;
            }
           else if(kilomenters >=20&&kilomenters<100)
            {
                price = kilomenters * 0.09;
            }
            else if (kilomenters >=100)
            {
                price = kilomenters * 0.06;
            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
