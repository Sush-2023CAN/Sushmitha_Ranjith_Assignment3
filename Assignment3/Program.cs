using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;


    class Program
    {
        static void Main()
        {
            RentalAgency agency = new RentalAgency(10); // Create an agency with a fleet capacity of 10 vehicles

            Car car = new Car
            {
                Model = "Toyota Camry",
                Manufacturer = "Toyota",
                Year = 2022,
                RentalPrice = 50,
                Seats = 5,
                EngineType = "V6",
                Transmission = "Automatic",
                Convertible = false
            };

            Truck truck = new Truck
            {
                Model = "Ford F-150",
                Manufacturer = "Ford",
                Year = 2021,
                RentalPrice = 80,
                Capacity = 2,
                TruckType = "Pickup",
                FourWheelDrive = true
            };

            Motorcycle motorcycle = new Motorcycle
            {
                Model = "Honda CBR500R",
                Manufacturer = "Honda",
                Year = 2020,
                RentalPrice = 30,
                EngineCapacity = 500,
                FuelType = "Gasoline",
                HasFairing = true
            };


            agency.AddVehicle(car);
            agency.AddVehicle(truck);
            agency.AddVehicle(motorcycle);

            // car.DisplayDetails();
            //truck.DisplayDetails();
            // motorcycle.DisplayDetails();

            //agency.RentVehicle(car, 3);
            //agency.RentVehicle(truck, 5);
            //agency.RentVehicle(motorcycle, 2);

            Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
        }
    }


