namespace _06.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            FindCountOfVowels (input);
        }

        static void FindCountOfVowels(string text)
        {
            int counterOfVowels = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                switch (currentLetter)
                {
                    case 'a': 
                    case 'e': 
                    case 'i': 
                    case 'o': 
                    case 'u': 
                    case 'A': 
                    case 'E': 
                    case 'I': 
                    case 'O': 
                    case 'U':
                        counterOfVowels++;
                        break;  
                }
            }
            Console.WriteLine(counterOfVowels);
        }
    }
}
