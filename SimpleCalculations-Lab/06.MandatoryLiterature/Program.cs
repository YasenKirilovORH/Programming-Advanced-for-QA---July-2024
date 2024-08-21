namespace _06.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalReadingTime = numberOfPages / pagesPerHours;

            int hoursPerDay = totalReadingTime / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
