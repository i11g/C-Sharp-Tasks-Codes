using System;

namespace Zoo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberDogs=int.Parse(Console.ReadLine());
            double numberCats=int.Parse(Console.ReadLine());

            double totalSum = (numberCats * 4) + (numberDogs * 2.5);
            Console.WriteLine($"{totalSum} lv.");
        }
    }
}
