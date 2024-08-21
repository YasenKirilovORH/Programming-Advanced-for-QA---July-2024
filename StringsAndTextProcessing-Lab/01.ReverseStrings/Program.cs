namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            while (word != "end")
            {
                string reversedWord = "";

                for (int position = word.Length - 1; position >= 0; position--)
                {
                    char currentSymbol = word[position];

                    reversedWord += currentSymbol;
                }

                Console.WriteLine(word + " = " + reversedWord);

                word = Console.ReadLine();
            }
        }
    }
}
