using System.Reflection.Metadata.Ecma335;

namespace _09.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!CheckPasswordIsBetweenSixAndTenCharacters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!CheckPasswordContainsOnlyLettersAndNumbers(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!CheckIfPassswordContainsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (CheckPasswordIsBetweenSixAndTenCharacters(password) &&
                CheckPasswordContainsOnlyLettersAndNumbers(password) &&
                CheckIfPassswordContainsAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckPasswordIsBetweenSixAndTenCharacters(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }

        static bool CheckPasswordContainsOnlyLettersAndNumbers(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentCharacter = password[i];

                if (!char.IsLetterOrDigit(currentCharacter))
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckIfPassswordContainsAtLeastTwoDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char currentCharacter = password[i];

                if (char.IsDigit(currentCharacter))
                {
                    counter++;

                    if (counter >= 2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
