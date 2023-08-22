using System;

namespace Literature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages=int.Parse(Console.ReadLine());
            int pagesForOneHour=int.Parse(Console.ReadLine()) ;
            int numberOfDays=int.Parse(Console.ReadLine()) ;

            int numberOfHours = numberOfPages / pagesForOneHour;
            int hoursPerDay = numberOfHours / numberOfDays;
            Console.WriteLine(hoursPerDay);

       
        }
    }
}
