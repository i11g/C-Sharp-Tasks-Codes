using System;

namespace Fuel_Tank_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double price = 0;

            switch (type)
            {
                case "Diesel":
                    if (clubCard == "Yes")
                    {
                        price = quantity * 2.33 - quantity * 0.12;
                    }
                    else
                    {
                        price = quantity * 2.33;
                    }
                    break;
                case "Gas":
                    if (clubCard == "Yes")
                    {
                        price = quantity * 0.93 - quantity * 0.08;
                    }
                    else
                    {
                        price = quantity * 0.93;
                    }
                    break;
                case "Gasoline":
                    if (clubCard == "Yes")
                    {
                        price = quantity * 2.22 - quantity * 0.18;
                    }
                    else
                    {
                        price = quantity * 2.22;
                    }
                    break;
            }
            if (quantity > 20 && quantity <= 25)
            {
                price = price - price * 0.08;
            }
            else if (quantity > 25)
            {

                price = price - price * 0.10;
            }

            Console.WriteLine($"{price:f2} lv.");


        }
        
    }
}
