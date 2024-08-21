namespace _04.NumbersEndingIn7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the end of the range: ");
            int endRange = int.Parse(Console.ReadLine());

            for (int i = 7; i <= endRange; i += 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
