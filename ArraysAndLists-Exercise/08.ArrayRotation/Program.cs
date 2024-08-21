namespace _08.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rotatitons = int.Parse(Console.ReadLine());

            int rotationsNeeded = rotatitons % line.Length;

            for (int i = 0; i < rotationsNeeded; i++)
            {
                int firstElement = line[0];

                for (int j = 1; j < line.Length; j++)
                {
                    line[j - 1] = line[j];
                }

                line[line.Length - 1] = firstElement;
            }

            Console.WriteLine(String.Join(" ", line));
        }
    }
}
