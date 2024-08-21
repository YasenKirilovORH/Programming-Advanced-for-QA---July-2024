using System.Diagnostics.Tracing;

namespace _02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ");

            string result = "";

            foreach (string word in words)
            {
                int length = word.Length;

                for (int i = 1; i <= length; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
