using System;

namespace Time__15_min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours=int.Parse(Console.ReadLine());
            int minutes=int.Parse(Console.ReadLine());

            int totalminutes=hours*60+minutes+15;
            int newHours=totalminutes/60;
            int newMinutes = totalminutes % 60;


            if (hours == 23 && minutes == 45)
            {
                Console.WriteLine($"{0}:0{0}");
            }

            else if (hours == 23 && minutes >= 45&&minutes<=50)
            {
                Console.WriteLine($"0:0{newMinutes}");
            }
            else if (hours == 23 && minutes >= 45)
            {
                Console.WriteLine($"0:{newMinutes}");
            }
            else if (newMinutes < 10 && hours == 23)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }
            else if (newMinutes > 10 && hours == 23)
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
                        
            else if (newMinutes > 10 && hours != 23)
            {
                Console.WriteLine($"{newHours}:{newMinutes}");
            }
            else if (newMinutes < 10 && hours != 23)
            {
                Console.WriteLine($"{newHours}:0{newMinutes}");
            }

        }
    }
}
