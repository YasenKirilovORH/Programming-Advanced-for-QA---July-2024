namespace _06.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string companyName = input.Split(" -> ")[0];
                string employeeID = input.Split(" -> ")[1];

                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees.Add(companyName, new List<string>()); 
                }

                List<string> employeesList = companyEmployees[companyName];

                if (!employeesList.Contains(employeeID))
                {
                    employeesList.Add(employeeID);
                }

                input = Console.ReadLine();
            }

            foreach(KeyValuePair<string, List<string>> entry in companyEmployees)
            {
                Console.WriteLine(entry.Key);
                entry.Value.ForEach(employeeID => Console.WriteLine($"-- {employeeID}"));
            }
        }
    }
}
