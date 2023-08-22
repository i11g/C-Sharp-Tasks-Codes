using System;

namespace Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name=Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int projectsHours = projects * 3;

            Console.WriteLine($"The architect {name} will need {projectsHours} to complete {projects} projects"); 

        }

    }
}
