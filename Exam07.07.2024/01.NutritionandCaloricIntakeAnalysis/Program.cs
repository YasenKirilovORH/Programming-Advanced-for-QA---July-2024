namespace _01.NutritionandCaloricIntakeAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;

            if (count <= 0)
            {
                Console.WriteLine(0);
            }

            for (int i = 1; i<= count; i++)
            {
                int caloricValue = int.Parse(Console.ReadLine());
    
                sum += caloricValue;
                Console.Write(sum);

                if (caloricValue <= 0)
                {
                    caloricValue = 0;
                }
                
                Console.WriteLine();
            }
        }
    }
}
