namespace _04.Sequence2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.Parse(Console.ReadLine());

            int sum = 1;
            while (sum <= maxNum)
            {
                Console.WriteLine(sum);
                sum = sum * 2 + 1;
            }
        }
    }
}
