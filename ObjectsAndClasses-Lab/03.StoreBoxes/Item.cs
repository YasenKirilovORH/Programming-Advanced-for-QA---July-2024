using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StoreBoxes
{
    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
