using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"[+]359([ -])2\1[0-9]{3}\1[0-9]{4}";

            Regex regexPhoneNumber = new Regex(pattern);

            MatchCollection validPhoneNumbers = regexPhoneNumber.Matches(text);

            for(int position = 0; position <= validPhoneNumbers.Count-1; position++)
            {
                if (position == validPhoneNumbers.Count-1)
                {
                    Console.Write(validPhoneNumbers[position].Value);
                }
                else
                {
                    Console.Write(validPhoneNumbers[position].Value + ", ");
                }
            }
        }
    }
}
