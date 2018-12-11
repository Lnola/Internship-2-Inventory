using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Internship_2_Inventory
{
    class Inventory
    {
        public Inventory(List<Computer> computers, List<Phone> phones, List<Vehicle> vehicles)
        {
            Computers = computers;
            Phones = phones;
            Vehicles = vehicles;
        }

        public List<Computer> Computers { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        //public void Print()
        //{
        //    foreach (var i in Computers)
        //    {
        //        i.Print();
        //    }
        //}
    }
}
