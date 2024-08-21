namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> output = new List<int>();

            int iterations = 0;

            if (firstList.Count > secondList.Count)
            {
                iterations = firstList.Count;
            }
            else
            {
                 iterations = secondList.Count;
            }

            for (int i = 0; i < iterations; i++)
            {
                if (i < firstList.Count)
                {
                    int currentNumFromFirstList = firstList[i];
                    output.Add(currentNumFromFirstList);
                }
                if (i < secondList.Count)
                {
                    int currentNumFromSecondList = secondList[i];
                    output.Add(currentNumFromSecondList);
                }
            }

            Console.WriteLine(string.Join (" ", output));
        }
    }
}
