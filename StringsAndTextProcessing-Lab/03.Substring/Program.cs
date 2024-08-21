namespace _03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textToBeRemoved = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.IndexOf(textToBeRemoved) != -1) 
            {
                int possitionOfTheWord = text.IndexOf(textToBeRemoved);

                text = text.Remove(possitionOfTheWord, textToBeRemoved.Length);
            }

            Console.WriteLine(text);
        }
    }
}
