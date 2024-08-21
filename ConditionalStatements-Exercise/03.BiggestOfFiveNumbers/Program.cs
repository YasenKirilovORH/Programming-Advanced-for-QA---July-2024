namespace _03.BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            int numFive = int.Parse(Console.ReadLine());

            if (numOne > numTwo && numOne > numThree && numOne > numFour && numOne > numFive) 
            {
                Console.WriteLine(numOne);
            }
            else if (numTwo > numThree && numTwo > numFour && numTwo > numFive)
            {
                Console.WriteLine(numTwo);
            }
            else if (numThree > numFour && numThree > numFive)
            {
                Console.WriteLine(numThree);
            }
            else if (numFour > numFive)
            {
                Console.WriteLine(numFour);
            }
            else
            {
                Console.WriteLine(numFive);

            }
        }
    }
}
