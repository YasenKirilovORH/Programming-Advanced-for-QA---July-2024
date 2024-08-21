namespace _08.NumberProcessor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                number = command == "Inc" ? number + 1 : number - 1;
            }

            Console.WriteLine(number);
        }
    }
}
