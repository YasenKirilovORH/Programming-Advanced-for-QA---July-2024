namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                             .Split(" ");

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach(string word in words)
            {
                string wordWithLowerCases = word.ToLower();

                if (!wordsCount.ContainsKey(wordWithLowerCases))
                {
                    wordsCount.Add(wordWithLowerCases, 1);
                }
                else
                {
                    wordsCount[wordWithLowerCases]++;
                }
            }
            foreach(KeyValuePair<string, int> entry in wordsCount)
            {
                if (entry.Value % 2 != 0)
                {
                    Console.Write(entry.Key + " ");
                }
            }
        }
    }
}
