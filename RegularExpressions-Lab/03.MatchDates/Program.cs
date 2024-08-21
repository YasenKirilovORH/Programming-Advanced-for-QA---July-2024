using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(?<day>[0-9]{2})(?<separator>[\.\/\-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})";

            Regex regexDate = new Regex(pattern);

            MatchCollection validDates = regexDate.Matches(text);

            foreach (Match validDate in validDates)
            {
                string day = validDate.Groups["day"].Value;
                string month = validDate.Groups["month"].Value;
                string year = validDate.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
