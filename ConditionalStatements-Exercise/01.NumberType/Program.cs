namespace _01.NumberType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("negative");
            }
            else if (number > 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}
