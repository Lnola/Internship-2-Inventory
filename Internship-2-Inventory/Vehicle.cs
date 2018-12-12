using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Vehicle : Category
    {
        public Vehicle(Guid serialNumber, string description, DateTime purchaseDate, int warranty, int purchasePrice,
            string manufacturer, DateTime registartionexpirationDate, string mileage)
            : base(serialNumber, description, purchaseDate, warranty, purchasePrice, manufacturer)
        {
            RegistartionExpirationDate = registartionexpirationDate;
            Mileage = mileage;
        }

        public DateTime RegistartionExpirationDate { get; set; }
        public string Mileage { get; set; }

        public void Print()
        {
            Console.WriteLine(SerialNumber);
            Console.WriteLine(Description);
            Console.WriteLine(PurchaseDate);
            Console.WriteLine(Warranty);
            Console.WriteLine(PurchasePrice);
            Console.WriteLine(Manufacturer);
            Console.WriteLine(RegistartionExpirationDate);
            Console.WriteLine(Mileage);
            Console.WriteLine();
        }

        public void PrintSerialNumber()
        {
            Console.WriteLine(SerialNumber);
            Console.WriteLine();

        }
    }
}
