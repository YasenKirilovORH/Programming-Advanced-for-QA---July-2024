namespace _05.DivisionTo2_3And4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = int.Parse(Console.ReadLine());

            int divideBy2 = 0;
            int divideBy3 = 0;
            int divideBy4 = 0;

            for (int i = 1; i <= totalNumbers; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input % 2 == 0)
                {
                    divideBy2++;
                }
                if (input % 3 == 0)
                {
                    divideBy3++;
                }
                if (input % 4 == 0)
                {
                    divideBy4++;
                }
            }
            double percentageDivideBy2 = divideBy2 / (double)totalNumbers * 100;
            double percentageDivideBy3 = divideBy3 / (double)totalNumbers * 100;
            double percentageDivideBy4 = divideBy4 / (double)totalNumbers * 100;

            Console.WriteLine($"{percentageDivideBy2:F2}%");
            Console.WriteLine($"{percentageDivideBy3:F2}%");
            Console.WriteLine($"{percentageDivideBy4:F2}%");
        }
    }
}
