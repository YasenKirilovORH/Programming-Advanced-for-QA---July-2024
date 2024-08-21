namespace _07.SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());

            int lastNumber = 0;

            while (lastNumber != stopNumber)
            {
                int input = int.Parse(Console.ReadLine());

                if (input == stopNumber)
                {
                    double output = lastNumber + lastNumber * 20 / 100;
                    Console.WriteLine(output);
                    break;
                }

                lastNumber = input;
            }
        }
    }
}
