using System;

namespace Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            char holiday = char.Parse(Console.ReadLine());
            double price = 0;
            double totalPrice = 0;
            int numberFlowers = hrizantemi + roses + tulips;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    if (holiday == 'Y')
                    {
                        price = (hrizantemi * 2 + roses * 4.10 + tulips * 2.50) * 1.15;
                        totalPrice = price + 2;
                        if (tulips > 7)
                        {
                            price = price - price * 0.05;

                        }
                        if (numberFlowers > 20)
                        {
                            price = price - price * 0.20;

                        }
                    }
                    if (holiday == 'N')
                    {
                        price = (hrizantemi * 2 + roses * 4.10 + tulips * 2.50);
                        totalPrice = price + 2;
                        if (tulips > 7)
                        {
                            price = price - price * 0.05;

                        }
                        if (numberFlowers > 20)
                        {
                            price = price - price * 0.20;

                        }
                    }

                    break;

                case "Winter":
                case "Autumn":
                    if (holiday == 'Y')
                    {
                        price = (hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15) * 1.15;
                        totalPrice = price + 2;
                        if (roses > 10)
                        {
                            price = price - price * 0.10;

                        }
                        else if (numberFlowers > 20)
                        {
                            price = price - price * 0.20;

                        }
                    }
                    else if (holiday == 'N')
                    {
                        price = (hrizantemi * 3.75 + roses * 4.50 + tulips * 4.15);
                        totalPrice = price + 2;
                        if (roses > 10)
                        {
                            price = price - price * 0.10;

                        }
                        if (numberFlowers > 20)
                        {
                            price = price - price * 0.20;

                        }
                    }

                    break;
            }
            totalPrice = price + 2;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
    }

