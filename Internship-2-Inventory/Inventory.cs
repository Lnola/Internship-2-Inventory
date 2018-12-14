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
                Console.WriteLine("Ta godina isteka garancije ne postoji!\n");
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
                if (Vehicles[i].RegistartionExpirationDate <= Vehicles[i].TodayDatePlusMonth() && Vehicles[i].RegistartionExpirationDate>=DateTime.Now)
                {
                    Vehicles[i].Print();
                    exists = true;
                }
            }
            if(!exists)
                Console.WriteLine("Ne postoji vozilo cija registracija istice u iducih mjesec dana\n");
        }

        public void PrintTask6(int type)
        {
            switch (type)
            {
                case 1:
                    Console.WriteLine("\nPostojeci proizvodaci mobitela:\n");

                    if(Phones.Count>0)
                        foreach (var i in Phones)
                        {
                            i.PrintManufacturer();
                        }
                    else
                        Console.WriteLine("Ne postoji niti jedan mobitel!");

                    break;

                case 2:
                    Console.WriteLine("\nPostojeci operativni sustavi:\n");

                    if (Computers.Count > 0)
                        foreach (var i in Computers)
                        {
                            i.PrintOperatingSystem();
                        }
                    else
                        Console.WriteLine("Ne postoji niti jedno racunalo!");

                    break;
            }

            Console.WriteLine();
        }

        public void PrintByTask6(int type, string input)
        {
            //in the last review you said it's easier to use return; instead of bool as flaggs but in this case i used bool because it needs to print all the 
            //phones with this manufacturer not just one. I was wandering if there's an easier way to do this without the bool variable

            switch (type)
            {
                case 1:
                    Console.WriteLine("\nTrazeni mobiteli:\n");
                    var exists = false;

                    foreach (var i in Phones)
                    {
                        if (input == i.Manufacturer.ToLower())
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if (!exists)
                        Console.WriteLine("Nijedan mobitel nega tog proizvodaca! Povratak na opcije\n");

                    break;

                case 2:
                    Console.WriteLine("\nTrazena racunala:\n");
                    exists = false;

                    foreach (var i in Computers)
                    {
                        if (input == i.OperatingSystem.ToLower())
                        {
                            i.Print();
                            exists = true;
                        }
                    }

                    if (!exists)
                        Console.WriteLine("Nijedno racunalo nema taj operativni sustav! Povratak na opcije\n");

                    break;;
            }
        }

        public void PrintMoney()
        {
            foreach (var i in Vehicles)
            {
                var difference = i.PurchasePrice - i.ChangingPrice();
                Console.WriteLine("Vozilo - " + i.Description + ":");
                Console.WriteLine("Originalna cijena: " + i.PurchasePrice);
                Console.WriteLine("Trenutna vrijednost: " + i.ChangingPrice());
                Console.WriteLine("Razlika cijena: " + difference);
                Console.WriteLine();
            }
            foreach (var i in Computers)
            {
                var difference = i.PurchasePrice - i.ChangingTechPrice();
                Console.WriteLine("Racunalo - " + i.Description + ":");
                Console.WriteLine("Originalna cijena: " + i.PurchasePrice);
                Console.WriteLine("Trenutna vrijednost: " + i.ChangingTechPrice());
                Console.WriteLine("Razlika cijena: " + difference);
                Console.WriteLine();
            }

            foreach (var i in Phones)
            {
                var difference = i.PurchasePrice - i.ChangingTechPrice();
                Console.WriteLine("Mobitel - " + i.Description + ":");
                Console.WriteLine("Originalna cijena: " + i.PurchasePrice);
                Console.WriteLine("Trenutna vrijednost: " + i.ChangingTechPrice());
                Console.WriteLine("Razlika cijena: " + difference);
                Console.WriteLine();
            }
        }
    }
}