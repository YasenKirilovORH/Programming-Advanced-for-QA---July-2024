namespace _02.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentData = input.Split(" ");

                string firstName = studentData[0];
                string lastName = studentData[1];
                int age = int.Parse(studentData[2]);
                string homeTown = studentData[3];

                Student student = new Student(firstName, lastName, age, homeTown);

                studentsList.Add(student);


                input=Console.ReadLine();
            }

            string cityToBePrinted = Console.ReadLine();

            foreach (Student student in studentsList)
            {
                if (student.HomeTown == cityToBePrinted)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
