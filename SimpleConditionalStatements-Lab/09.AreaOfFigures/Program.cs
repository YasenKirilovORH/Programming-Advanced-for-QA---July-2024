namespace _09.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            double area = 0;

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            } 
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius; 
            }
            Console.WriteLine($"{area:F2}");
        }
    }
}
