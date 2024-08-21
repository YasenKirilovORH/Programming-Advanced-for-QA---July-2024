using System.Runtime.InteropServices;

namespace _07.ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architecturesName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());

            int totalHours = projectsCount * 3;

            Console.WriteLine($"The architect {architecturesName} will need {totalHours} hours to complete {projectsCount} project/s.");
        }
    }
}
