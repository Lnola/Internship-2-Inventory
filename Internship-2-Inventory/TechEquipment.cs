using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class TechEquipment : Category
    {
        public TechEquipment(Guid serialNumber, string description, DateTime purchaseDate, int warranty,
            int purchasePrice, string manufacturer, bool battery)
            : base(serialNumber, description, purchaseDate, warranty, purchasePrice, manufacturer)
        {
            Battery = battery;
        }

        public bool Battery { get; set; }
    }
}
