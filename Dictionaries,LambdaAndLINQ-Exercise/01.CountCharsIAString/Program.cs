namespace _01.CountCharsIAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach(char character in text)
            {
                if (character != ' ')
                {
                    if (charCount.ContainsKey(character))
                    {
                        charCount[character]++;
                    }
                    else
                    {
                        charCount.Add(character, 1);
                    }
                }
            }

            foreach(KeyValuePair<char, int> entry in charCount)
            {
                Console.WriteLine(entry.Key + " -> " + entry.Value);
            }
        }
    }
}
