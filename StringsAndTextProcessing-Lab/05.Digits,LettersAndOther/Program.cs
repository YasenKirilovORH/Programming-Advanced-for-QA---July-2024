using System.Text;

namespace _05.Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sbDigits = new StringBuilder();
            StringBuilder sbLetters = new StringBuilder();
            StringBuilder sbOthers = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (char.IsDigit(currentChar))
                {
                    sbDigits.Append(currentChar);
                }
                else if (char.IsLetter(currentChar))
                {
                    sbLetters.Append(currentChar);
                }
                else
                {
                    sbOthers.Append(currentChar);
                }
            }
            Console.WriteLine(sbDigits);
            Console.WriteLine(sbLetters);
            Console.WriteLine(sbOthers);
        }
    }
}
