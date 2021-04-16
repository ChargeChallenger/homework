using System;
using System.Collections.Generic;
using System.Text;

namespace console_project
{
    class Laptop
    {
        public string Name { get; set; }
        public Manufacturer LaptopManufacturer { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public Laptop (string name, Manufacturer manufacturer, int price, string descript, int amount)
        {
            Name = name;
            LaptopManufacturer = manufacturer;
            Price = price;
            Description = descript;
            Amount = amount;
        }
    }
}
