using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Computer : TechEquipment
    {
        public Computer(Guid serialNumber, string description, DateTime purchaseDate, int warranty, double purchasePrice,
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
            Console.WriteLine("Serial Number: "+SerialNumber);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Purchase Date: " + String.Format("{0:dd/MM/yyyy}", PurchaseDate));
            Console.WriteLine("Warranty: " + Warranty);
            Console.WriteLine("Purchase Price: " + PurchasePrice);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Battery: " + Battery);
            Console.WriteLine("Operating System: " + OperatingSystem);
            Console.WriteLine("Portability: " + Portable);
            Console.WriteLine();
        }

        public void PrintSerialNumber()
        {
            Console.WriteLine(SerialNumber);
            Console.WriteLine();
        }

        public int WarrantyExpirationYear()
        {
            var warrantyExpiration = new DateTime(PurchaseDate.Year, PurchaseDate.Month, PurchaseDate.Day);
            warrantyExpiration = warrantyExpiration.AddMonths(Warranty);
            int year = warrantyExpiration.Year;

            return year;
        }

        public void PrintOperatingSystem()
        {
            Console.WriteLine(OperatingSystem);
        }
    }
}
