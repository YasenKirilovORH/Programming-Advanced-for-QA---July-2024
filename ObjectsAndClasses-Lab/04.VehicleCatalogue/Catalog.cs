using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VehicleCatalogue
{
    public class Catalog
    {
        public List<Car> Cars {  get; set; }
        public List<Truck> Trucks { get; set; }

        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }
    }
}
