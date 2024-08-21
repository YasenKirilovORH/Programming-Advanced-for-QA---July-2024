namespace _08.SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            bool isAscending = numOne < numTwo && numTwo < numThree;
            bool isDescending = numOne > numTwo && numTwo > numThree;

            if (isAscending)
            {
                Console.WriteLine("Ascending");
            }
            else if (isDescending)
            {
                Console.WriteLine("Descending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
    }
}
