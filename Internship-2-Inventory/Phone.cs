using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Phone : TechEquipment
    {
        public Phone(Guid serialNumber, string description, DateTime purchaseDate, int warranty, int purchasePrice,
            string manufacturer, bool battery, string phoneNumber, string nameOfOwner)
            : base(serialNumber, description, purchaseDate, warranty, purchasePrice, manufacturer, battery)
        {
            PhoneNumber = phoneNumber;
            NameOfOwner = nameOfOwner;
        }

        public string PhoneNumber { get; set; }
        public string NameOfOwner { get; set; }

        public void Print()
        {
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Purchase Date: " + String.Format("{0:dd/MM/yyyy}", PurchaseDate));
            Console.WriteLine("Warranty: " + Warranty);
            Console.WriteLine("Purchase Price: " + PurchasePrice);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Battery: " + Battery);
            Console.WriteLine("Phone Number: " + PhoneNumber);
            Console.WriteLine("Name Of Owner: " + NameOfOwner);
            Console.WriteLine();
        }

        public void PrintSerialNumber()
        {
            Console.WriteLine(SerialNumber);
            Console.WriteLine();

        }

        public int PhoneWarrantyExpiration()
        {
            var warrantyExpiration = new DateTime(PurchaseDate.Year, PurchaseDate.Month, PurchaseDate.Day);
            warrantyExpiration = warrantyExpiration.AddMonths(Warranty);
            int year = warrantyExpiration.Year;

            return year;
        }

        public void PrintNames()
        {
            Console.WriteLine("Phone Number: " + PhoneNumber);
            Console.WriteLine("Name Of Owner: " + NameOfOwner);
        }

        public void PrintManufacturer()
        {
            Console.WriteLine(Manufacturer);
        }
    }
}
