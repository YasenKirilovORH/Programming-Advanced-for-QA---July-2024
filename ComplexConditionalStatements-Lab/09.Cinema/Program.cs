namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfMovie = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int totalSeats = rows * seats;
            decimal priceOfTicket = 0m;

            switch (typeOfMovie)
            {
                case "Premiere":
                    priceOfTicket = 12.00m;
                    break;
                case "Normal":
                    priceOfTicket = 7.50m;
                    break;
                case "Discount":
                    priceOfTicket = 5.00m;
                    break;

                    
            }
            decimal totalPrice = totalSeats * priceOfTicket;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
