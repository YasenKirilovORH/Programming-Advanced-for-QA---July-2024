namespace _04.TrapezoidArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseA = int.Parse(Console.ReadLine());
            int baseB = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = (baseA + baseB) / 2 * height;

            Console.WriteLine(area);

        }
    }
}
