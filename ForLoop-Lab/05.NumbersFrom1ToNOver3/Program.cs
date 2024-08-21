namespace _05.NumbersFrom1ToNOver3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endRange; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
