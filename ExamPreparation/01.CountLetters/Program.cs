using System.ComponentModel;

namespace _01.CountLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int upperLettersCount = 0;
            int lowerLettersCount = 0;
            int whiteSpaceLettersCount = 0;

            foreach (char letter in input)
            {
                char currentChar = letter;

                if (char.IsUpper(currentChar))
                {
                    upperLettersCount++;
                }
                else if (char.IsLower(currentChar))
                {
                    lowerLettersCount++;
                }
                else
                {
                    whiteSpaceLettersCount++;
                }
            }
            Console.WriteLine(upperLettersCount);
            Console.WriteLine(lowerLettersCount);
            Console.WriteLine(whiteSpaceLettersCount);
        }
    }
}
