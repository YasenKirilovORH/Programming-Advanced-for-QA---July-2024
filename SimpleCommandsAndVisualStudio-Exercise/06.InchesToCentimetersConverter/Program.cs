namespace _06.InchesToCentimetersConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double cmInOneInch = 2.54;

            double centimeters = inches * cmInOneInch;

            Console.WriteLine(centimeters);
        }
    }
}
