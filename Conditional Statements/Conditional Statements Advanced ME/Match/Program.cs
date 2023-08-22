using System;

namespace Match
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPeople = int.Parse(Console.ReadLine());
            double moneyNeeded = 0;
            double transport = 0;
            double moneyLeft = 0;

            switch (category)
            {
                case "VIP":
                    if (numberPeople >= 1 && numberPeople <= 5)
                    {
                        transport = budget * 0.75;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else if (numberPeople >= 5 && numberPeople <= 9)
                    {
                        transport = budget * 0.60;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else if (numberPeople >= 10 && numberPeople <= 24)
                    {
                        transport = budget * 0.50;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else if (numberPeople >= 25 && numberPeople <= 49)
                    {
                        transport = budget * 0.50;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else
                    {
                        transport = budget * 0.50;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    break;
                case "Normal":
                    if (numberPeople >= 1 && numberPeople <= 5)
                    {
                        transport = budget * 0.75;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else if (numberPeople >= 5 && numberPeople <= 9)
                    {
                        transport = budget * 0.60;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else if (numberPeople >= 10 && numberPeople <= 24)
                    {
                        transport = budget * 0.50;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else if (numberPeople >= 25 && numberPeople <= 49)
                    {
                        transport = budget * 0.50;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    else
                    {
                        transport = budget * 0.50;
                        moneyLeft = budget - transport;
                        moneyNeeded = numberPeople * 250;

                        if (moneyLeft < moneyNeeded)
                        {
                            double left = moneyNeeded - moneyLeft;
                            Console.WriteLine($"Not enough money! You need {left:F2}");
                        }
                        else
                        {
                            double left = moneyLeft - moneyNeeded;
                            Console.WriteLine($"Yes! You have {left:F2} leva left");
                        }
                    }
                    break;
            }


        }
    }

    }

