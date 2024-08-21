namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourOfTheDay = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (hourOfTheDay >= 10 && hourOfTheDay <= 18)
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":                       
                    case "Saturday":
                        Console.WriteLine("open");
                        break;
                       
                    case "Sunday":
                        Console.WriteLine("closed");
                        break;

                }
             
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
