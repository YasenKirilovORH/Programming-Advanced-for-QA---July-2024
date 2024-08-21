namespace _05.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeatCount = int.Parse(Console.ReadLine());

            string result = Repeat (input, repeatCount);
            Console.WriteLine(result);

            static string Repeat (string input, int count)
            {
                string result = "";
                
                for (int i = 1; i <= count; i++)
                {
                    result += input;
                }
                return result;
            }
        }
    }
}
