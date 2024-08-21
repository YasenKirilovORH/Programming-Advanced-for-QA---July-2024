namespace _02.First_NumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= endNum; i++)
            {
                sum += i;
                if (i == endNum)
                {
                    Console.Write($"{i}=");
                }
                else
                {
                    Console.Write($"{i}+");
                }

            }
            Console.WriteLine(sum);
        }
    }
}
