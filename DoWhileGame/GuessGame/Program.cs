namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "yasen";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuessess = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuessess = true;
                }
                

            } while (guess != secretWord && !outOfGuessess);

            if (outOfGuessess )
            {
                Console.WriteLine("Yo Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
            
        }
    }
}
