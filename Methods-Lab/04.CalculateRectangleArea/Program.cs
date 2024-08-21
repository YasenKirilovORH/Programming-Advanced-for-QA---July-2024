namespace _04.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int area = CalculateArea(width, length);
            Console.WriteLine(area);

            static int CalculateArea(int w, int l)
            {
                int result = w * l;
                return result;
            }
        }
    }
}
