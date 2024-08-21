namespace _10.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            string clothes = string.Empty;
            string shoes = string.Empty;

            if (temperature >= 10 && temperature <= 18)
            {
            switch (timeOfTheDay)
                {
                    case "Morning":
                        clothes = "Sweatshirt";
                        shoes = "Sneakers";
                        break;

                    case "Afternoon":
                    case "Evening":
                        clothes = "Shirt";
                        shoes = "Moccasins";
                        break;

                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                switch (timeOfTheDay)
                {
                    case "Morning":
                    case "Evening":
                        clothes = "Shirt";
                        shoes = "Moccasins";
                        break;

                    case "Afternoon":
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                        break;
                }
            }
            else
            {
                switch (timeOfTheDay)
                {
                    case "Morning":
                        clothes = "T-Shirt";
                        shoes = "Sandals";
                        break;

                    case "Afternoon":
                        clothes = "Swim Suit";
                        shoes = "Barefoot";
                        break;

                    case "Evening":
                        clothes = "Shirt";
                        shoes = "Moccasins";
                        break;

                }
            }
            Console.WriteLine($"It's {temperature} degrees, get your {clothes} and {shoes}.");
        }
    }
}
