using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Computer : TechEquipment
    {
        public Computer(Guid serialNumber, string description, DateTime purchaseDate, int warranty, int purchasePrice,
            string manufacturer, bool battery, string operatingSystem, bool portable)
            : base(serialNumber, description, purchaseDate, warranty, purchasePrice, manufacturer, battery)
        {
            OperatingSystem = operatingSystem;
            Portable = portable;
        }

        public string OperatingSystem { get; set; }
        public bool Portable { get; set; }

        public void Print()
        {
            Console.WriteLine(SerialNumber);
            Console.WriteLine(Description);
            Console.WriteLine(PurchaseDate);
            Console.WriteLine(Warranty);
            Console.WriteLine(PurchasePrice);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(Battery);
            Console.WriteLine(OperatingSystem);
            Console.WriteLine(Portable);
            Console.WriteLine();
        }
    }
}
