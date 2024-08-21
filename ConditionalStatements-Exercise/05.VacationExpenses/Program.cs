namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfVacation = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            int pricePerNight = 0;
            double discount = 0;

            switch (season)
            {
                case "Spring":
                    if (typeOfVacation == "Hotel")
                    {
                        pricePerNight = 30;
                    }
                    else if (typeOfVacation == "Camping")
                    {
                        pricePerNight = 10;
                    }
                    discount = 20;
                    break;

                case "Summer":
                    if (typeOfVacation == "Hotel")
                    {
                        pricePerNight = 50;
                    }
                    else if (typeOfVacation == "Camping")
                    {
                        pricePerNight = 30;
                    }
                    break;

                case "Autumn":
                    if (typeOfVacation == "Hotel")
                    {
                        pricePerNight = 20;
                    }
                    else if (typeOfVacation == "Camping")
                    {
                        pricePerNight = 15;
                    }
                    discount = 30;
                    break;

                case "Winter":
                    if (typeOfVacation == "Hotel")
                    {
                        pricePerNight = 40;
                    }
                    else if (typeOfVacation == "Camping")
                    {
                        pricePerNight = 10;
                    }
                    discount = 10;
                    break;
            }

            double totalPriceWithoutDiscount = pricePerNight * days;
            double discountAmount = totalPriceWithoutDiscount * discount / 100;
            double finalPrice = totalPriceWithoutDiscount - discountAmount;

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
