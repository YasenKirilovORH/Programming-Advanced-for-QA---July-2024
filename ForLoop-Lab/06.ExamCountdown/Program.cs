namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalDaysUntilExam = int.Parse(Console.ReadLine());

            for (int day = totalDaysUntilExam; day >= 1; day--)
            {
                Console.WriteLine($"{day} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}
