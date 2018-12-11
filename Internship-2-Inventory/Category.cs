using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class Category
    {
        public Category(Guid serialNumber, string description, DateTime purchaseDate, int warranty, int purchasePrice, string manufacturer)
        {
            SerialNumber = serialNumber;
            Description = description;
            PurchaseDate = purchaseDate;
            Warranty = warranty;
            PurchasePrice = purchasePrice;
            Manufacturer = manufacturer;
        }

        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Warranty { get; set; }
        public int PurchasePrice { get; set; }
        public string Manufacturer { get; set; }
    }
}
