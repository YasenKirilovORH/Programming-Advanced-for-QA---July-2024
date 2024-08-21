namespace _04.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int estates = int.Parse(Console.ReadLine());

            for (int row = floors; row >= 1; row--)
            {
                for (int col = 0; col < estates; col++)
                {
                   if (row == floors)
                    {
                        Console.Write($"L{row}{col} ");
                    }
                   else if (row % 2 == 1)
                    {
                        Console.Write($"A{row}{col } ");
                    }
                   else
                    {
                        Console.Write($"O{row}{col} ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
