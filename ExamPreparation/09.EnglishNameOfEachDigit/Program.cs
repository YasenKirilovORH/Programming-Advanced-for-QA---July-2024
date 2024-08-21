namespace _09.EnglishNameOfEachDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            while (number > 0)
            {
                int currentDayNumber = number % 10;
                number /= 10;
                numbers.Add(currentDayNumber);
            }

            foreach (int num in numbers)
            {
                List<string> words = new List<string>();
                switch (num)
                {
                    case 1:
                        words.Add("one");
                        break;
                    case 2:
                        words.Add("two");
                        break;
                    case 3:
                        words.Add("three");
                        break;
                    case 4:
                        words.Add("four");
                        break;
                    case 5:
                        words.Add("five");
                        break;
                    case 6:
                        words.Add("six");
                        break;
                    case 7:
                        words.Add("seven");
                        break;
                    case 8:
                        words.Add("eight");
                        break;
                    case 9:
                        words.Add("nine");
                        break;
                }
                Console.WriteLine(String.Join(" ", words));
            }
        }
    }
}

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int number = int.Parse(Console.ReadLine());

//        while (number > 0)
//        {
//            int currentDayNumber = number % 10;

//            switch (currentDayNumber)
//            {
//                case 1: Console.WriteLine("one"); break;
//                case 2: Console.WriteLine("two"); break;
//                case 3: Console.WriteLine("three"); break;
//                case 4: Console.WriteLine("four"); break;
//                case 5: Console.WriteLine("five"); break;
//                case 6: Console.WriteLine("six"); break;
//                case 7: Console.WriteLine("seven"); break;
//                case 8: Console.WriteLine("eight"); break;
//                case 9: Console.WriteLine("nine"); break;
//            }
//            number /= 10;
//        }
//    }
//}

