using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;

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


        public void InputComputers(Computer newComputer)
        {
            Computers.Add(newComputer);
        }

        public void InputPhones(Phone newPhone)
        {
            Phones.Add(newPhone);
        }

        public void InputVehicles(Vehicle newVehicle)
        {
            Vehicles.Add(newVehicle);
        }

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

        public void PrintSerialNumbers()
        {
            foreach (var i in Computers)
            {
                i.PrintSerialNumber();
            }

            foreach (var i in Phones)
            {
                i.PrintSerialNumber();
            }

            foreach (var i in Vehicles)
            {
                i.PrintSerialNumber();
            }
        }

        public void PrintBySerialNumber(Guid sentSerialNumber)
        {
            Console.WriteLine("Trazeni item: \n");

            for (var i = 0; i < Computers.Count; i++)
            {
                if (Computers[i].SerialNumber == sentSerialNumber)
                {
                    Computers[i].Print();
                    break;
                }
            }

            for (var i = 0; i < Phones.Count; i++)
            {
                if (Phones[i].SerialNumber == sentSerialNumber)
                {
                    Phones[i].Print();
                    break;
                }
            }

            for (var i = 0; i < Vehicles.Count; i++)
            {
                if (Vehicles[i].SerialNumber == sentSerialNumber)
                {
                    Vehicles[i].Print();
                    break;
                }
            }
        }

        public void PrintByWarrantyYear(int warrantyYear)
        {
            var exisits = false;
            for (var i = 0; i < Computers.Count; i++)
            {
                if (Computers[i].WarrantyExpirationYear() == warrantyYear)
                {
                    Computers[i].Print();
                    exisits = true;
                }
            }
            if(!exisits)
                Console.WriteLine("Ta godina isteka garancije ne postoji!");
        }

        public void NumberOfBatteries()
        {
            var numberOfBatteries = 0;

            for (var i = 0; i < Computers.Count; i++)
            {
                if (Computers[i].Battery)
                {
                    numberOfBatteries++;
                }
            }

            for (var i = 0; i < Phones.Count; i++)
            {
                if (Phones[i].Battery)
                {
                    numberOfBatteries++;
                }
            }

            Console.WriteLine("\nUkupan broj proizvoda s baterijama je: " + numberOfBatteries + "\n");
        }

        public void PhoneWarrantyExpiration(int warrantyExpiration)
        {
            var exisits = false;
            for (var i = 0; i < Phones.Count; i++)
            {
                if (Phones[i].PhoneWarrantyExpiration() == warrantyExpiration)
                {
                    Phones[i].PrintNames();
                    Console.WriteLine();
                    exisits = true;
                }
            }
            if (!exisits)
                Console.WriteLine("Ta godina isteka garancije ne postoji!\n");
        }

        public void PrintVehiclesByRegistration()
        {
            var exists = false;
            for (var i = 0; i < Vehicles.Count; i++)
            {
                if (Vehicles[i].RegistartionExpirationDate <= Vehicles[i].PurchaseDatePlusMonth())
                {
                    Vehicles[i].Print();
                    exists = true;
                }
            }
            if(!exists)
                Console.WriteLine("Ne postoji vozilo cija registracija istice u iducih mjesec dana\n");
        }
    }
}