using System;
using System.Collections.Generic;

namespace Internship_2_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInventory = new Inventory(ComputerInitialisation(), PhoneInitialisation(), VehicleInitialisation());
            
            //myInventory.Print();

            //Todo: Add options description!

            var option = "";

            do
            {
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "2":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "3":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "4":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "5":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "6":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "7":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "8":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "9":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    case "0":
                        Console.WriteLine("Odabrali ste opciju: ");
                        break;
                    default:
                        Console.WriteLine("Krivi unos!");
                        break;
                }

            } while (option!="0");
        }

        static List<Computer> ComputerInitialisation()
        {
            var computers = new List<Computer>()
            {
                new Computer(Guid.NewGuid(), "Prvo Racunalo", new DateTime(2008, 5, 1), 20, 2000, "Asus", true, "Windows 10", true),
                new Computer(Guid.NewGuid(), "Drugo Racunalo", new DateTime(2008, 10, 1), 4, 2000, "Dell", false, "Windows 7", false),
            };
            return computers;
        }

        static List<Phone> PhoneInitialisation()
        {
            var phones = new List<Phone>()
            {
                new Phone(Guid.NewGuid(), "Prvi Mobitel", new DateTime(2008, 1, 1), 4, 2000, "Samsung", true, "099 999 999", "Mate Matic"),
                new Phone(Guid.NewGuid(), "Drugi Mobitel", new DateTime(2008, 12, 1), 2, 2000, "Nokia", true, "098 888 888", "Jure Juric")
            };
            return phones;
        }

        static List<Vehicle> VehicleInitialisation()
        {
            var vehicles = new List<Vehicle>()
            {
                new Vehicle(Guid.NewGuid(), "Prvo Vozilo", new DateTime(2008, 5, 1), 24, 2000, "Toyota", new DateTime(2009, 5, 1), 120.120),
                new Vehicle(Guid.NewGuid(), "Drugo Vozilo", new DateTime(2008, 1, 12), 25, 2000, "Fiat", new DateTime(2009, 1, 13), 0.00)
            };
            return vehicles;
        }
    }
}
