using System.Data;

namespace _07.NumberProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Inc")
                {
                    number++;
                }
                else
                {
                    number--;
                }
            }

            Console.WriteLine(number);
        }
    }
}
