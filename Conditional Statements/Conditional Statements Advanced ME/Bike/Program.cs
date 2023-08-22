using System;

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();
            double sum = 0;
            double totalSum = 0;

            switch (trace)
            {
                case "trail":
                    sum = juniors * 5.50 + seniors * 7;
                    totalSum = sum - sum * 0.05;
                    break;
                case "cross-country":
                    sum = juniors * 8 + seniors * 9.50;
                    totalSum = sum - sum * 0.05;
                    int participants = juniors + seniors;
                    if (participants >= 50)
                    {
                        totalSum = totalSum - totalSum * 0.25;
                    }
                    break;
                case "downhill":
                    sum = juniors * 12.25 + seniors * 13.75;
                    totalSum = sum - sum * 0.05;
                    break;
                case "road":
                    sum = juniors * 20 + seniors * 21.50;
                    totalSum = sum - sum * 0.05;
                    break;
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
    }

