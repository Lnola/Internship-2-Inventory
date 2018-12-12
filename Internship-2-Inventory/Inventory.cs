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

        
        public void Print(int type)
        {
            switch (type)
            {
                case 1:
                    Console.WriteLine("Inventar racunala:\n");
                    foreach (var i in Computers)
                    {
                        i.Print();
                    }

                    break;
                case 2:
                    Console.WriteLine("Inventar mobitela:\n");
                    foreach (var i in Phones)
                    {
                        i.Print();
                    }

                    break;
                case 3:
                    Console.WriteLine("Inventar vozila:\n");
                    foreach (var i in Vehicles)
                    {
                        i.Print();
                    }

                    break;
            }
        }

        public int Size(int type)
        {
            var size = 0;

            switch (type)
            {
                case 1:
                    size = Computers.Count;

                    break;
                case 2:
                    size = Phones.Count;

                    break;
                case 3:
                    size = Vehicles.Count;

                    break;
            }

            return size;
        }

        public void Delete(int type, Guid serialNumber)
        {
            switch (type)
            {
                case 1:
                    for (var i = 0; i < Computers.Count; i++)
                    {
                        if (Computers[i].SerialNumber == serialNumber)
                        {
                            Computers.RemoveAt(i);
                            break;
                        }
                    }

                    break;
                case 2:
                    for (var i = 0; i < Phones.Count; i++)
                    {
                        if (Phones[i].SerialNumber == serialNumber)
                        {
                            Phones.RemoveAt(i);
                            break;
                        }
                    }

                    break;
                case 3:
                    for (var i = 0; i < Vehicles.Count; i++)
                    {
                        if (Vehicles[i].SerialNumber == serialNumber)
                        {
                            Vehicles.RemoveAt(i);
                            break;
                        }
                    }

                    break;
            }
        }
    }
}
