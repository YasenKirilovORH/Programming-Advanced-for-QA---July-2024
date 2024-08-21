namespace _05.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            int countEntries = int.Parse(Console.ReadLine());

            for(int count = 1; count <= countEntries; count++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(!studentsGrades.ContainsKey(name))
                {
                    studentsGrades.Add(name, new List<double>());
                    studentsGrades[name].Add(grade);
                }
                else
                {
                    studentsGrades[name].Add(grade);
                }
            }
            
            foreach(KeyValuePair<string, List<double>> entry in studentsGrades)
            {
                double averageGrade = entry.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{entry.Key} -> {averageGrade:F2}");
                }
            }
        }
    }
}
