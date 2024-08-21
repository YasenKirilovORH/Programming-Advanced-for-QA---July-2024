namespace _02.LargestNumberOutOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());


            if (firstNum > secondNum)
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine(firstNum);
                }
            }
            else if (secondNum > thirdNum)
            {
                Console.WriteLine(secondNum);
            }
            else
            {
                Console.WriteLine(thirdNum);
            }
        }

   
    }
}
