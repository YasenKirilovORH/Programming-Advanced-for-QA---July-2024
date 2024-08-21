namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, quantity);
                }
                else
                {
                    resources[resource] += quantity;
                }
                resource = Console.ReadLine();
            }
            foreach (KeyValuePair<string, int> pair in resources)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
