namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ");

            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string replacement = "";

                for (int i = 1; i <= word.Length; i++)
                {
                    replacement += "*";
                }

                text = text.Replace(word, replacement);
            }

            Console.WriteLine(text);
        }
    }
}
