using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Vehicle : Category
    {
        public Vehicle(Guid serialNumber, string description, DateTime purchaseDate, int warranty, double purchasePrice,
            string manufacturer, DateTime registartionexpirationDate, int mileage)
            : base(serialNumber, description, purchaseDate, warranty, purchasePrice, manufacturer)
        {
            RegistartionExpirationDate = registartionexpirationDate;
            Mileage = mileage;
        }

        public DateTime RegistartionExpirationDate { get; set; }
        public int Mileage { get; set; }

        public void Print()
        {
            Console.WriteLine("Serial Number: " + SerialNumber);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Purchase Date: " + String.Format("{0:dd/MM/yyyy}", PurchaseDate));
            Console.WriteLine("Warranty: " + Warranty);
            Console.WriteLine("Purchase Price: " + PurchasePrice);
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Registration Expiration Date: " + String.Format("{0:dd/MM/yyyy}", RegistartionExpirationDate));
            Console.WriteLine("Mileage: " + Mileage);
            Console.WriteLine();
        }

        public void PrintSerialNumber()
        {
            Console.WriteLine(SerialNumber);
            Console.WriteLine();

        }

        public DateTime TodayDatePlusMonth()
        {
            var todayPlusMonth = DateTime.Now.AddMonths(1);

            return todayPlusMonth;
        }

        public double ChangingPrice()
        {
            var money = PurchasePrice;
            var kilometers = Mileage;

            while (kilometers >= 20000)
            {
                if (money >= 0.8 * PurchasePrice)
                    money = money * 0.9;
                if (money < 0.8 * PurchasePrice)
                {
                    money = PurchasePrice * 0.8;
                    break;
                }
                kilometers -= 20000;
            }

            return money;
        }
    }
}
