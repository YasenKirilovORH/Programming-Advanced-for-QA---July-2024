using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regexFullName = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            MatchCollection namesThatMatch = regexFullName.Matches(text);

            foreach(Match matchingFullName in namesThatMatch)
            {
                Console.Write(matchingFullName.Value + " ");
            }
        }
    }
}
