using System;

namespace Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine(); 
            double quantity=double.Parse(Console.ReadLine());

            if (type !="Diesel"&&type!="Gas"&&type!="Gasoline")
            {
                Console.WriteLine($"Invalid fuel!");
            }
            
            if (type =="Diesel")
            {
                if(quantity >= 25)
                {
                    Console.WriteLine($"You have enough diesel.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }
            }
            else if (type =="Gas")
            {
                if (quantity >= 25)
                {
                    Console.WriteLine($"You have enough gas.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
            }
            else if (type == "Gasoline")
            {
                if (quantity >= 25)
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
            }

        }
    }
}
