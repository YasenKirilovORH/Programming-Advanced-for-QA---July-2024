namespace _04.LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char excludedLetter = char.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = startLetter; i <= endLetter; i++)
            {
                for (int j = startLetter; j <= endLetter; j++)
                {
                    for (int k = startLetter; k <= endLetter; k++)
                    {
                        if (i.Equals(excludedLetter) || j.Equals(excludedLetter) || k.Equals(excludedLetter))
                        {
                            continue;
                        }
                        Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        counter++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(counter);
        }
    }
}
