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

        public Inventory(List<Computer> computers)
        {
            Computers = computers;
        }

        public Inventory(List<Phone> phones)
        {
            Phones = phones;
        }

        public Inventory(List<Vehicle> vehicles)
        {
            Vehicles = vehicles;
        }

        public List<Computer> Computers { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public void PrintComputers()
        {
            foreach (var i in Computers)
            {
                i.Print();
            }
        }

        public void PrintPhones()
        {
            foreach (var i in Phones)
            {
                i.Print();
            }
        }

        public void PrintVehicles()
        {
            foreach (var i in Vehicles)
            {
                i.Print();
            }
        }
    }
}
