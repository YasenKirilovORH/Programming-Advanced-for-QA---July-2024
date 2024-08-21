namespace _02.ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());
            
            if (limit > withdraw)
            {
                if (withdraw < balance)
                {
                    Console.WriteLine("The withdraw was successful.");
                }
                else
                {
                    Console.WriteLine("Insufficient availability.");
                }
            }
            else
            {
                Console.WriteLine("The limit was exceeded.");
            }
        }
    }
}
