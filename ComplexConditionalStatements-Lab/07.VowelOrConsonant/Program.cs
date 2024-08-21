namespace _07.VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char @char = char.Parse(Console.ReadLine());

            //Vowels letters are: A, a, E, e, I, i, O, o, U, u
            switch (@char) {
                case 'A':
                case 'a':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Consonant");
                    break;
            }
        }
    }
}
