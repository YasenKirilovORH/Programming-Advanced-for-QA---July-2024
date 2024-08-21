namespace _06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {

                int currentCardPlayer1 = firstPlayerCards[0];
                int currentCardPlayer2 = secondPlayerCards[0];
              

                        if (currentCardPlayer1 > currentCardPlayer2)
                        {
                            firstPlayerCards.Add(currentCardPlayer1);
                            firstPlayerCards.Add(currentCardPlayer2);
                            firstPlayerCards.RemoveAt(0);
                            secondPlayerCards.RemoveAt(0);
                        }
                        else if (currentCardPlayer1 < currentCardPlayer2)
                        {
                            secondPlayerCards.Add(currentCardPlayer2);
                            secondPlayerCards.Add(currentCardPlayer1);
                            secondPlayerCards.RemoveAt(0);
                            firstPlayerCards.RemoveAt(0);
                        }
                        else
                        {
                            firstPlayerCards.RemoveAt(0);
                            secondPlayerCards.RemoveAt(0);
                        }
            }

            if (firstPlayerCards.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
        }
    }
}
