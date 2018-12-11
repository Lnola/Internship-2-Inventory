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
    }
}
