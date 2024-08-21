namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of Program to call the printText method
            Program program = new Program();
            program.printText("Programming");
        }

        public void printText(string text)
        {
            // Base case to stop recursion
            if (text == "C#")
            {
                Console.WriteLine("I love" + text);
                return;
            }

            // Recursive call
            Console.WriteLine("I love " + text);
            printText("C#");
        }
    }
}