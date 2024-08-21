namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfInputNums = int.Parse(Console.ReadLine());

            int biggestNum = int.MinValue;

            for (int i = 1; i <= countOfInputNums; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum >= biggestNum)
                {
                    biggestNum = currentNum;
                }

            }
            Console.WriteLine(biggestNum);
        }
    }
}
