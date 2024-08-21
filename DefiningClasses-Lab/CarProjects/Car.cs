using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        private Engine engine;
        private Tire[] tires;
        public void Drive (double distance)
        {
            double neededFuel = distance * FuelConsumption;

            if (FuelConsumption <= neededFuel)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= neededFuel;
            }
        }

        public string WhoAmI()
        {
            StringBuilder sbInfoCar = new StringBuilder();
            sbInfoCar.AppendLine("Make " + Make);
            sbInfoCar.AppendLine("Model " + Model);
            sbInfoCar.AppendLine("Year " + Year);
            sbInfoCar.AppendLine($"Fuel {FuelQuantity:F2}");

            return sbInfoCar.ToString();
        }
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;

        }

        public Car (string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car (string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car (string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}
