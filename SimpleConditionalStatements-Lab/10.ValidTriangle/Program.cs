namespace _10.ValidTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int sideC = int.Parse(Console.ReadLine());

            int counter = 0;

            if (sideA < sideB + sideC)
            {
                counter++;
            }
            if (sideB < sideA + sideC)
            {
                counter++;
            }
            if (sideC < sideA + sideB)
            {
                counter++;
            }
            if (counter == 3)
            {
                Console.WriteLine("Valid Triangle");
            }
            else
            {
                Console.WriteLine("Invalid Triangle");
            }
        }
    }
}
