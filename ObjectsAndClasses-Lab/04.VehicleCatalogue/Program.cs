using System.Reflection;

namespace _04.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            List<Truck> truckList = new List<Truck>();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string[] veichleDetails = input.Split("/", StringSplitOptions.RemoveEmptyEntries);
                string typeOfVeichle = veichleDetails[0];
                string brand = veichleDetails[1];
                string model = veichleDetails[2];

                if (typeOfVeichle == "Car")
                {
                    int horsePower = int.Parse(veichleDetails[3]);

                    Car car = new Car(brand, model, horsePower);
                    carList.Add(car);
                }
                else
                {
                    int weight = int.Parse(veichleDetails[3]);

                    Truck truck = new Truck(brand, model, weight);
                    truckList.Add(truck);
                }
                    

                input = Console.ReadLine();
            }
            if(carList.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in carList.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if(truckList.Count > 0) {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in truckList.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
