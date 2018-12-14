using System;
using System.Collections.Generic;
using System.Text;

namespace Internship_2_Inventory
{
    class TechEquipment : Category
    {
        public TechEquipment(Guid serialNumber, string description, DateTime purchaseDate, int warranty,
            double purchasePrice, string manufacturer, bool battery)
            : base(serialNumber, description, purchaseDate, warranty, purchasePrice, manufacturer)
        {
            Battery = battery;
        }

        public bool Battery { get; set; }

        public double ChangingTechPrice()
        {
            var money = PurchasePrice;
            var monthsPassed = Math.Abs(DateTime.Now.Month - PurchaseDate.Month) + 12 * (DateTime.Now.Year - PurchaseDate.Year);

            while (monthsPassed != 0)
            {
                if (money >= 0.7 * PurchasePrice)
                    money = money * 0.95;
                if (money < 0.7 * PurchasePrice)
                {
                    money = PurchasePrice * 0.7;
                    break;
                }

                monthsPassed--;
            }

            return money;
        }
    }
}
