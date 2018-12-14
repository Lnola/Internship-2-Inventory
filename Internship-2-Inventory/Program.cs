using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Internship_2_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInventory = new Inventory(ComputerInitialisation(), PhoneInitialisation(), VehicleInitialisation());
            var option = "";

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Opcije:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1. Dodavanje novog itema u inventar\n" +
                                  "2. Brisanje postojeceg itema iz inventara\n" +
                                  "3. Prikaz itema preko serijskog broja\n" +
                                  "4. Pretraga racunala po godini isteka garancije\n" +
                                  "5. Ukupni broj proizvoda s baterijama\n" +
                                  "6. Pretraga mobitela po markama ili pretraga racunala po operativnom sustavu\n" +
                                  "7. Pretraga vlasnika vozila po godini isteka garncije\n" +
                                  "8. Vozila kojima registracija istice u iducih mjesec dana\n" +
                                  "9. Ispis cijene pri kupnji i trenutne vrijednosti\n" +
                                  "0. Ispis svih itema u inventaru i izlazak iz programa\n" +
                                  "\nUnesi redni broj opcije (bez tocke): ");
                                  
                option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Odabrali ste opciju: Dodavanje novog itema u inventar!");
                        Console.Write("Unesi odabir kategorije rijecima Tehnoloska oprema ili Vozila: ");
                        var choice = Console.ReadLine();
                        choice = choice.ToLower();
                        if (choice == "tehnoloska oprema")
                        {
                            Console.Write("Unesi odabir kategorije rijecima Racunala ili Mobiteli: ");
                            choice = Console.ReadLine();
                            choice = choice.ToLower();

                            if (choice == "racunala")
                            {
                                Console.Write("Unesi opis: ");
                                var description = Console.ReadLine();
                                Console.Write("Unesi godinu kupovine u obliku broja: ");
                                var year = Console.ReadLine();
                                Console.Write("Unesi mjesec kupovine u obliku broja u intervalu od 1 do 12: ");
                                var month = Console.ReadLine();
                                Console.Write("Unesi dan kupovine u obliku broja u intervalu od 1 do 30: ");
                                var day = Console.ReadLine();
                                Console.Write("Unesi garanciju u obliku broja veceg od 0: ");
                                var warranty = Console.ReadLine();
                                Console.Write("Unesi cijenu pri kupnji u obliku broja: ");
                                var initialPrice = Console.ReadLine();
                                Console.Write("Unesi proizvodaca: ");
                                var manufacturer = Console.ReadLine();
                                Console.Write("Unesi rijecima DA ili NE ima li uredaj bateriju: ");
                                var battery = Console.ReadLine();
                                Console.Write("Unesi ime operativnog sustava: ");
                                var os = Console.ReadLine();
                                Console.Write("Unesi rijecima DA ili NE je li uredaj prenosiv: ");
                                var portable = Console.ReadLine();

                                var newComputer = ComputersInput(description, year, month, day, warranty, initialPrice, manufacturer, battery, os, portable);
                                myInventory.InputComputers(newComputer);

                                Console.WriteLine("Novo racunalo uspjesno dodano!\n");
                                myInventory.Print(1);

                            }
                            else if (choice == "mobiteli")
                            {
                                Console.Write("Unesi opis: ");
                                var description = Console.ReadLine();
                                Console.Write("Unesi godinu kupovine u obliku broja: ");
                                var year = Console.ReadLine();
                                Console.Write("Unesi mjesec kupovine u obliku broja u intervalu od 1 do 12: ");
                                var month = Console.ReadLine();
                                Console.Write("Unesi dan kupovine u obliku broja u intervalu od 1 do 30: ");
                                var day = Console.ReadLine();
                                Console.Write("Unesi garanciju u obliku broja veceg od 0: ");
                                var warranty = Console.ReadLine();
                                Console.Write("Unesi cijenu pri kupnji u obliku broja: ");
                                var initialPrice = Console.ReadLine();
                                Console.Write("Unesi proizvodaca: ");
                                var manufacturer = Console.ReadLine();
                                Console.Write("Unesi rijecima DA ili NE ima li uredaj bateriju: ");
                                var battery = Console.ReadLine();
                                Console.Write("Unesi broj mobitela vlasnika: ");
                                var phoneNumber = Console.ReadLine();
                                Console.Write("Unesi ime i prezime vlasnika mobitela: ");
                                var nameOfOwner = Console.ReadLine();

                                var newPhone = PhonesInput(description, year, month, day, warranty, initialPrice, manufacturer, battery, phoneNumber, nameOfOwner);
                                myInventory.InputPhones(newPhone);

                                Console.WriteLine("Novi mobitel uspjesno dodan!\n");
                                myInventory.Print(2);
                            }
                            else
                            {
                                Console.WriteLine("Pogresan unos! Povratak na opcije\n");
                            }
                        }
                        else if (choice == "vozila")
                        {
                            Console.Write("Unesi opis: ");
                            var description = Console.ReadLine();
                            Console.Write("Unesi godinu kupovine u obliku broja: ");
                            var year = Console.ReadLine();
                            Console.Write("Unesi mjesec kupovine u obliku broja u intervalu od 1 do 12: ");
                            var month = Console.ReadLine();
                            Console.Write("Unesi dan kupovine u obliku broja u intervalu od 1 do 30: ");
                            var day = Console.ReadLine();
                            Console.Write("Unesi garanciju u obliku broja veceg od 0: ");
                            var warranty = Console.ReadLine();
                            Console.Write("Unesi cijenu pri kupnji u obliku broja: ");
                            var initialPrice = Console.ReadLine();
                            Console.Write("Unesi proizvodaca: ");
                            var manufacturer = Console.ReadLine();
                            Console.Write("Unesi godinu isteka registracije vozila u obliku broja: ");
                            var registrationYear = Console.ReadLine();
                            Console.Write("Unesi mjesec isteka registracije vozila u obliku broja u intervalu od 1 do 12: ");
                            var registrationMonth = Console.ReadLine();
                            Console.Write("Unesi dan isteka registracije vozilau obliku broja u intervalu od 1 do 30: ");
                            var registrationDay = Console.ReadLine();
                            Console.Write("Unesi broj kilometraze na vozilu u obliku broja: ");
                            var mileage = Console.ReadLine();

                            var newVehicle = VehiclesInput(description, year, month, day, warranty, initialPrice,
                                manufacturer, registrationYear, registrationMonth, registrationDay, mileage);
                            myInventory.InputVehicles(newVehicle);

                            Console.WriteLine("Novo vozilo uspjesno dodano!\n");
                            myInventory.Print(3);
                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos! Povratak na opcije\n");
                        }

                        break;

                    case "2":
                        Console.WriteLine("Odabrali ste opciju: Brisanje postojeceg itema iz inventara");
                        Console.Write("Unesi kategoriju iz koje zelis izbrisati item rijecima Racunalo, Mobitel ili Vozilo: ");
                        choice = Console.ReadLine();
                        choice = choice.ToLower();

                        Console.WriteLine();
                        var serialInput = Guid.NewGuid();

                        if (choice == "racunalo")
                        {
                            myInventory.Print(1);
                            Console.Write("Kopiraj i zaljepi serijski broj racunala koji zelis izbrisati: ");
                            serialInput = Guid.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Racunalo uspjesno izbrisano!\n");

                            DeleteItem(serialInput, myInventory, choice);

                        }
                        else if (choice == "mobitel")
                        {
                            myInventory.Print(2);
                            Console.Write("Kopiraj i zaljepi serijski broj mobitela koji zelis izbrisati: ");
                            serialInput = Guid.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Mobitel uspjesno izbrisan!\n");

                            DeleteItem(serialInput, myInventory, choice);

                        }
                        else if (choice == "vozilo")
                        {
                            myInventory.Print(3);
                            Console.Write("Kopiraj i zaljepi serijski broj vozila koje zelis izbrisati: ");
                            serialInput = Guid.Parse(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Vozilo uspjesno izbrisano!\n");

                            DeleteItem(serialInput, myInventory, choice);

                        }
                        else
                        {
                            Console.WriteLine("Pogresan unos! Povratak na opcije.\n");
                        }

                        break;

                    case "3":
                        Console.WriteLine("Odabrali ste opciju: Prikaz itema preko serijskog broja");

                        Console.WriteLine("Ovo su serijski brojevi:\n");
                        
                        myInventory.PrintSerialNumbers();

                        //expected from the user to paste a serial number so it's not checking if it's in GUID format
                        Console.Write("Kopiraj i zaljepi serijski broj: ");
                        var serialNumber = Guid.Parse(Console.ReadLine());
                        Console.WriteLine();

                        myInventory.PrintBySerialNumber(serialNumber);

                        break;

                    case "4":
                        Console.WriteLine("Odabrali ste opciju: Pretraga racunala po godini isteka garancije");
                        Console.Write("Unesi godinu isteka garancije: ");
                        var warrantyYear = Console.ReadLine();
                        Console.WriteLine("\nRezultat pretrage:\n");

                        PrintByWarrantyYear(warrantyYear, myInventory);

                        break;

                    case "5":
                        Console.WriteLine("Odabrali ste opciju: Ukupni broj proizvoda s baterijama");
                        
                        myInventory.NumberOfBatteries();

                        break;

                    case "6":
                        //I did this task without using enum because I forgot to use it earlier
                        //Changing it now would require changing a lot of things and it would only complicate the way I did the whole task
                        //That's why I decided to leave it as is and do the 6th task in a seperate project. The link to the project is in the Readme

                        Console.WriteLine("Odabrali ste opciju: Pretraga mobitela po markama ili pretraga racunala po operativnom sustavu");
                        Console.Write("Unesi kategotiju koji zelis pretraziti rijecima Mobiteli ili Racunala: ");
                        var input = Console.ReadLine();
                        input = input.ToLower();

                        if (input == "mobiteli")
                        {
                            myInventory.PrintTask6(1);

                            Console.Write("Unesi jednog od postojecih proizvodaca mobitela: ");
                            var input2 = Console.ReadLine();
                            input2 = input2.ToLower();

                            myInventory.PrintByTask6(1, input2);

                        }
                        else if (input == "racunala")
                        {
                            myInventory.PrintTask6(2);

                            Console.Write("Unesi jedan od postojecih operativnih sustava: ");
                            var input2 = Console.ReadLine();
                            input2 = input2.ToLower();

                            myInventory.PrintByTask6(2, input2);

                        }
                        else
                            Console.WriteLine("Pogresan unos! Povratak na opcije.\n");

                        break;

                    case "7":
                        Console.WriteLine("Odabrali ste opciju: Pretraga vlasnika vozila po godini isteka garncije");
                        Console.Write("Unesi godinu isteka garancije: ");
                        var warrantyExpiration = Console.ReadLine();

                        PrintNameByWarrantyYear(warrantyExpiration,myInventory);

                        break;

                    case "8":
                        Console.WriteLine("Odabrali ste opciju: Ispis vozila kojima registracija istice u iducih mjesec dana");
                        Console.WriteLine("Ta vozila su:\n");

                        myInventory.PrintVehiclesByRegistration();

                        break;

                    case "9":
                        Console.WriteLine("Odabrali ste opciju: Ispis cijene pri kupnji i trenutne vrijednosti");
                        Console.WriteLine();
                        myInventory.PrintMoney();

                        break;

                    case "0":
                        Console.WriteLine("Odabrali ste opciju: Izlazak iz programa\n");

                        myInventory.Print(1);
                        myInventory.Print(2);
                        myInventory.Print(3);

                        break;

                    default:
                        Console.WriteLine("Pogresan unos! Povratak na opcije");
                        break;
                }

            } while (option!="0");
        }


        static List<Computer> ComputerInitialisation()
        {
            var computers = new List<Computer>()
            {
                new Computer(Guid.NewGuid(), "Prvo Racunalo", new DateTime(2008, 5, 1), 20, 12000, "Asus", true, "Windows 10", true),
                new Computer(Guid.NewGuid(), "Drugo Racunalo", new DateTime(2018, 10, 1), 4, 4000, "Dell", false, "Windows 7", false),
            };
            return computers;
        }

        static List<Phone> PhoneInitialisation()
        {
            var phones = new List<Phone>()
            {
                new Phone(Guid.NewGuid(), "Prvi Mobitel", new DateTime(2018, 9, 1), 4, 3000, "Samsung", true, "099 999 999", "Mate Matic"),
                new Phone(Guid.NewGuid(), "Drugi Mobitel", new DateTime(2017, 9, 17), 2, 20000, "Nokia", true, "098 888 888", "Jure Juric")
            };
            return phones;
        }

        static List<Vehicle> VehicleInitialisation()
        {
            var vehicles = new List<Vehicle>()
            {
                new Vehicle(Guid.NewGuid(), "Prvo Vozilo", new DateTime(2008, 5, 1), 24, 10000, "Toyota", new DateTime(2009, 5, 1), 40500),
                new Vehicle(Guid.NewGuid(), "Drugo Vozilo", new DateTime(2008, 1, 12), 25, 2000, "Fiat", new DateTime(2019, 1, 10), 200000)
            };
            return vehicles;
        }
  

        static Computer ComputersInput(string description, string year, string month, string day, string warranty,
            string initialPrice, string manufactutrer, string battery, string os, string portable)
        {
            //in the last code review you said not to use Int32.parse but the command Int.TryParse doesn't work and Int.Parse doesn't work as well 
            //because it cannot change a string of letters into int

            var yearAsInt = 0;
            var parsed = Int32.TryParse(year, out int a);
            if (parsed)
                yearAsInt = int.Parse(year);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za godinu, podatak mora biti broj!");
                Console.Write("Unesi godinu ponovno: ");
                year = Console.ReadLine();
                parsed = Int32.TryParse(year, out a);
                if (parsed)
                    yearAsInt = int.Parse(year);
            }

            var monthAsInt = 0;
            parsed = Int32.TryParse(month, out a);
            if (parsed)
                if (int.Parse(month) > 0 && int.Parse(month) < 13)
                    monthAsInt = int.Parse(month);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za mjesec, podatak mora biti broj!");
                Console.Write("Unesi mjesec ponovno: ");
                month = Console.ReadLine();
                parsed = Int32.TryParse(month, out a);
                if(parsed)
                    if (int.Parse(month) > 0 && int.Parse(month) < 13)
                        monthAsInt = int.Parse(month);
                    else
                        parsed = false;
            }

            var dayAsInt = 0;
            parsed = Int32.TryParse(day, out a);
            if (parsed)
                if (int.Parse(day) > 0 && int.Parse(day) < 31)
                    dayAsInt = int.Parse(day);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za dan, podatak mora biti broj!");
                Console.Write("Unesi dan ponovno: ");
                day = Console.ReadLine();
                parsed = Int32.TryParse(day, out a);
                if (parsed)
                    if (int.Parse(day) > 0 && int.Parse(day) < 31)
                        dayAsInt = int.Parse(day);
                    else
                        parsed = false;
            }

            parsed = Int32.TryParse(warranty, out a);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos garancije, podatak mora biti broj!");
                Console.Write("Unesi garanciju ponovno: ");
                warranty = Console.ReadLine();
                parsed = Int32.TryParse(warranty, out a);
            }

            parsed = Int32.TryParse(initialPrice, out a);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos cijene, podatak mora biti broj!");
                Console.Write("Unesi cijenu pri kupnji ponovno: ");
                initialPrice = Console.ReadLine();
                parsed = Int32.TryParse(initialPrice, out a);
            }

   
            var istrue = false;

            while (battery.ToLower() != "da" && battery.ToLower() != "ne")
            {
                Console.WriteLine("Pogresan unos na pitanje postoji li baterija, napisi rijec DA ili NE!");
                Console.Write("Unesi odgovor ponovno: ");
                battery = Console.ReadLine();
            }
            if (battery.ToLower() == "da")
                istrue = true;


            var isfalse = false;

            while (portable.ToLower() != "da" && portable.ToLower() != "ne")
            {
                Console.WriteLine("Pogresan unos na pitanje je li racunalo prenosivo, napisi rijec DA ili NE!");
                Console.Write("Unesi odgovor ponovno: ");
                portable = Console.ReadLine();
            }
            if (portable.ToLower() == "da")
                isfalse = true;



            Computer newComputer = new Computer(Guid.NewGuid(), description,
                new DateTime(yearAsInt, monthAsInt, dayAsInt), int.Parse(warranty),
                int.Parse(initialPrice), manufactutrer, istrue, os, isfalse);

            return newComputer;
        }


        static Phone PhonesInput(string description, string year, string month, string day, string warranty,
            string initialPrice, string manufactutrer, string battery, string phoneNumber, string nameOfOwner)
        {
            var yearAsInt = 0;
            var parsed = Int32.TryParse(year, out int a);
            if (parsed)
                yearAsInt = int.Parse(year);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za godinu, podatak mora biti broj!");
                Console.Write("Unesi godinu ponovno: ");
                year = Console.ReadLine();
                parsed = Int32.TryParse(year, out a);
                if (parsed)
                    yearAsInt = int.Parse(year);
            }

            var monthAsInt = 0;
            parsed = Int32.TryParse(month, out a);
            if (parsed)
                if (int.Parse(month) > 0 && int.Parse(month) < 13)
                    monthAsInt = int.Parse(month);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za mjesec, podatak mora biti broj!");
                Console.Write("Unesi mjesec ponovno: ");
                month = Console.ReadLine();
                parsed = Int32.TryParse(month, out a);
                if (parsed)
                    if (int.Parse(month) > 0 && int.Parse(month) < 13)
                        monthAsInt = int.Parse(month);
                    else
                        parsed = false;
            }

            var dayAsInt = 0;
            parsed = Int32.TryParse(day, out a);
            if (parsed)
                if (int.Parse(day) > 0 && int.Parse(day) < 31)
                    dayAsInt = int.Parse(day);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za dan, podatak mora biti broj!");
                Console.Write("Unesi dan ponovno: ");
                day = Console.ReadLine();
                parsed = Int32.TryParse(day, out a);
                if (parsed)
                    if (int.Parse(day) > 0 && int.Parse(day) < 31)
                        dayAsInt = int.Parse(day);
                    else
                        parsed = false;
            }

            parsed = Int32.TryParse(warranty, out a);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos garancije, podatak mora biti broj!");
                Console.Write("Unesi garanciju ponovno: ");
                warranty = Console.ReadLine();
                parsed = Int32.TryParse(warranty, out a);
            }

            parsed = Int32.TryParse(initialPrice, out a);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos cijene, podatak mora biti broj!");
                Console.Write("Unesi cijenu pri kupnji ponovno: ");
                initialPrice = Console.ReadLine();
                parsed = Int32.TryParse(initialPrice, out a);
            }


            var istrue = false;

            while (battery.ToLower() != "da" && battery.ToLower() != "ne")
            {
                Console.WriteLine("Pogresan unos na pitanje postoji li baterija, napisi rijec DA ili NE!");
                Console.Write("Unesi odgovor ponovno: ");
                battery = Console.ReadLine();
            }
            if (battery.ToLower() == "da")
                istrue = true;


            var newPhone = new Phone(Guid.NewGuid(), description, new DateTime(yearAsInt, monthAsInt, dayAsInt), 
                int.Parse(warranty), int.Parse(initialPrice), manufactutrer, istrue, phoneNumber, nameOfOwner);

            return newPhone;
        }


        static Vehicle VehiclesInput(string description, string year, string month, string day, string warranty,
            string initialPrice, string manufactutrer, string registrationYear, string registrationMonth, string registrationDay, string mileage)
        {
            var yearAsInt = 0;
            var parsed = Int32.TryParse(year, out int a);
            if (parsed)
                yearAsInt = int.Parse(year);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za godinu, podatak mora biti broj!");
                Console.Write("Unesi godinu ponovno: ");
                year = Console.ReadLine();
                parsed = Int32.TryParse(year, out a);
                if (parsed)
                    yearAsInt = int.Parse(year);
            }

            var monthAsInt = 0;
            parsed = Int32.TryParse(month, out a);
            if (parsed)
                if (int.Parse(month) > 0 && int.Parse(month) < 13)
                    monthAsInt = int.Parse(month);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za mjesec, podatak mora biti broj!");
                Console.Write("Unesi mjesec ponovno: ");
                month = Console.ReadLine();
                parsed = Int32.TryParse(month, out a);
                if (parsed)
                    if (int.Parse(month) > 0 && int.Parse(month) < 13)
                        monthAsInt = int.Parse(month);
                    else
                        parsed = false;
            }

            var dayAsInt = 0;
            parsed = Int32.TryParse(day, out a);
            if (parsed)
                if (int.Parse(day) > 0 && int.Parse(day) < 31)
                    dayAsInt = int.Parse(day);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za dan, podatak mora biti broj!");
                Console.Write("Unesi dan ponovno: ");
                day = Console.ReadLine();
                parsed = Int32.TryParse(day, out a);
                if (parsed)
                    if (int.Parse(day) > 0 && int.Parse(day) < 31)
                        dayAsInt = int.Parse(day);
                    else
                        parsed = false;
            }

            parsed = Int32.TryParse(warranty, out a);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos garancije, podatak mora biti broj!");
                Console.Write("Unesi garanciju ponovno: ");
                warranty = Console.ReadLine();
                parsed = Int32.TryParse(warranty, out a);
            }

            parsed = Int32.TryParse(initialPrice, out a);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos cijene, podatak mora biti broj!");
                Console.Write("Unesi cijenu pri kupnji ponovno: ");
                initialPrice = Console.ReadLine();
                parsed = Int32.TryParse(initialPrice, out a);
            }

            var registrationYearAsInt = 0;
            parsed = Int32.TryParse(registrationYear, out a);
            if (parsed)
                registrationYearAsInt = int.Parse(registrationYear);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za godinu isteka registracije, podatak mora biti broj!");
                Console.Write("Unesi godinu ponovno: ");
                registrationYear = Console.ReadLine();
                parsed = Int32.TryParse(registrationYear, out a);
                if (parsed)
                        registrationYearAsInt = int.Parse(registrationYear);
            }

            var registrationMonthAsInt = 0;
            parsed = Int32.TryParse(registrationMonth, out a);
            if (parsed)
                if (int.Parse(registrationMonth) > 0 && int.Parse(registrationMonth) < 13)
                    registrationMonthAsInt = int.Parse(registrationMonth);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za mjesec isteka registracije, podatak mora biti broj!");
                Console.Write("Unesi mjesec ponovno: ");
                registrationMonth = Console.ReadLine();
                parsed = Int32.TryParse(registrationMonth, out a);
                if (parsed)
                    if (int.Parse(registrationMonth) > 0 && int.Parse(registrationMonth) < 13)
                        registrationMonthAsInt = int.Parse(registrationMonth);
                    else
                        parsed = false;
            }

            var registrationDayAsInt = 0;
            parsed = Int32.TryParse(registrationDay, out a);
            if (parsed)
                if (int.Parse(registrationDay) > 0 && int.Parse(registrationDay) < 13)
                    registrationDayAsInt = int.Parse(registrationDay);
                else
                    parsed = false;
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos za dan isteka registracije, podatak mora biti broj!");
                Console.Write("Unesi dan ponovno: ");
                registrationDay = Console.ReadLine();
                parsed = Int32.TryParse(registrationDay, out a);
                if (parsed)
                    if (int.Parse(registrationDay) > 0 && int.Parse(registrationDay) < 13)
                        registrationDayAsInt = int.Parse(registrationDay);
                    else
                        parsed = false;
            }

            parsed = Int32.TryParse(mileage, out a);
            while (!parsed)
            {
                Console.WriteLine("Pogresan unos kilometraze, podatak mora biti broj!");
                Console.Write("Unesi prijedene kilometre ponovno: ");
                mileage = Console.ReadLine();
                parsed = Int32.TryParse(mileage, out a);
            }

            var newVehicle = new Vehicle(Guid.NewGuid(), description, new DateTime(yearAsInt, monthAsInt, dayAsInt),
                int.Parse(warranty), int.Parse(initialPrice), manufactutrer,
                new DateTime(registrationYearAsInt, registrationMonthAsInt, registrationDayAsInt), int.Parse(mileage));

            return newVehicle;
        }


        static Inventory DeleteItem(Guid serialNumber,Inventory myNewInventory, string choice)
        {
            switch (choice)
            {
                case "racunalo":
                    myNewInventory.Delete(1, serialNumber);
                    myNewInventory.Print(1);

                    break;

                case "mobitel":
                    myNewInventory.Delete(2, serialNumber);
                    myNewInventory.Print(2);

                    break;

                case "vozilo":
                    myNewInventory.Delete(3, serialNumber);
                    myNewInventory.Print(3);

                    break;
            }
            
            
            return myNewInventory;
        }

        static void PrintByWarrantyYear(string warrantyYear, Inventory myInventory)
        {
            var warrantyYearAsInt = 0;

            bool parsed = Int32.TryParse(warrantyYear, out int a);
            if (!parsed)
            {
                Console.WriteLine("Pogresan unos za godinu, podatak mora biti broj!\n");
                return;
            }
            else
            {
                warrantyYearAsInt = int.Parse(warrantyYear);
            }

            myInventory.PrintByWarrantyYear(warrantyYearAsInt);
        }

        static void PrintNameByWarrantyYear(string warrantyExpiration, Inventory myInventory)
        {
            var warrantyExpirationAsInt = 0;

            bool parsed = Int32.TryParse(warrantyExpiration, out int a);
            if (!parsed)
            {
                Console.WriteLine("Pogresan unos za godinu, podatak mora biti broj!\n");
                return;
            }
            else
            {
                warrantyExpirationAsInt = int.Parse(warrantyExpiration);
            }

            Console.WriteLine();
            myInventory.PhoneWarrantyExpiration(warrantyExpirationAsInt);
        }
    }
}