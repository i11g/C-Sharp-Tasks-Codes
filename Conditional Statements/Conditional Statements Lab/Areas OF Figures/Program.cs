using System;

namespace Areas_OF_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            double area = 0;

            if (input=="square")
            {
                double side=double.Parse(Console.ReadLine());
                area=side*side;
            }
            else if (input=="rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double   .Parse(Console.ReadLine());
                area=sideA*sideB;
            }
            else if (input == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area=Math.PI*radius*radius;
                
            }
            else if (input == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double high = double.Parse(Console.ReadLine());
                area = (sideA * high) / 2;
            }
            Console.WriteLine($"{area:F3}");
        }
    }
}
