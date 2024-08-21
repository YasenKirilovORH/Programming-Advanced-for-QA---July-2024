namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parkingList = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int count = 1; count <= numberOfCommands; count++)
            {
                string command = Console.ReadLine();

                if(command.Contains("unregister"))
                {
                    string ownerOut = command.Split(" ")[1];

                    if (!parkingList.ContainsKey(ownerOut))
                    {
                        Console.WriteLine($"ERROR: user {ownerOut} not found");
                    }
                    else
                    {
                        parkingList.Remove(ownerOut);
                        Console.WriteLine($"{ownerOut} unregistered successfully");
                    }
                }
                else if (command.Contains("register"))
                {
                    string owner = command.Split(" ")[1];
                    string plateNumber = command.Split(" ")[2];
                    
                    if(!parkingList.ContainsKey(owner))
                    {
                        parkingList.Add(owner, plateNumber);
                        Console.WriteLine($"{owner} registered {plateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
            }
            foreach(KeyValuePair<string, string> entry in parkingList)
            {
                Console.WriteLine(entry.Key + " => " + entry.Value );
            }
        }
    }
}
