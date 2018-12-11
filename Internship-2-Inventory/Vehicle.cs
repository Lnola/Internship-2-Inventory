using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Vehicle : Category
    {
        public Vehicle(Guid serialNumber, string description, DateTime purchaseDate, int warranty, int purchasePrice,
            string manufacturer, DateTime registartionexpirationDate, double milage)
            : base(serialNumber, description, purchaseDate, warranty, purchasePrice, manufacturer)
        {
            RegistartionExpirationDate = registartionexpirationDate;
            Milage = milage;
        }

        public DateTime RegistartionExpirationDate { get; set; }
        public double Milage { get; set; }
    }
}
