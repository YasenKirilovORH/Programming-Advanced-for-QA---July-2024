namespace _04.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string line = "";

            while ((line = Console.ReadLine()) != "end")
            {
                string[] tokens = line
                .Split(" ")
                .ToArray();

                string command = tokens[0];

                if (command == "Add") // Add {number}
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                else if (command == "Remove") // Remove {number}
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Remove(number);
                }
                else if (command == "RemoveAt") // RemoveAt {index}
                {
                    int index = int.Parse(tokens[1]);
                    numbers.RemoveAt(index);
                }
                else if (command == "Insert") // Insert {number} {index}
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    numbers.Insert(index, number);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
