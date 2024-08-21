namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsSynonyms = new Dictionary<string, List<string>>();

            int countWords = int.Parse(Console.ReadLine());

            for (int count = 1; count <= countWords; count++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsSynonyms.ContainsKey(word))
                {
                    wordsSynonyms.Add(word, new List<string>());
                    wordsSynonyms[word].Add(synonym);
                }
                else
                {
                    wordsSynonyms[word].Add(synonym);
                }
            }

            foreach(KeyValuePair<string, List<string>> entry in wordsSynonyms)
            {
                Console.WriteLine(entry.Key + " - " + string.Join(", ", entry.Value));
            }
        }
    }
}
