using System.Diagnostics;

namespace _08.TicketPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();

            decimal ticketPrice = 0m;

            if (ticketType == "student")
            {
                ticketPrice = 1.00m;
                Console.WriteLine($"${ticketPrice:F2}");
            }
            else if (ticketType == "regular")
            {
                ticketPrice = 1.60m;
                Console.WriteLine($"${ticketPrice:F2}");
            }
            else
            {
                Console.WriteLine("Invalid ticket type!");
            }
            
        }
    }
}
