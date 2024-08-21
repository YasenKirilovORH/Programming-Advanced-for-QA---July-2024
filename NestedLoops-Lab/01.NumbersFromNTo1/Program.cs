using System.Diagnostics;

namespace _01.NumbersFromNTo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int n = number; n >= 1; n--)
            {
                Console.WriteLine(n);
            }
        }
    }
}
