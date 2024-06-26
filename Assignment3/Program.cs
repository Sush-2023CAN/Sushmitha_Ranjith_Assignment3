﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;

namespace Assignment3 
{
    class Program
    {
        static void Main()
        {

            RentalAgency agency = new RentalAgency(100); // Create an agency with a fleet capacity of 10 vehicles

            Car car = new Car
            {
                model = "GMC",
                manufacturer = " Chevorlet",
                year =  2022,
                rentalPrice =  50,
                seats = 5,
                engineType = " V6",
                transmission = "Automatic",
                convertible = " Yes"
        };
               

            Truck truck = new Truck
            {
                model = "TACOMA",
                manufacturer = "Toyota",
                year = 2021,
                rentalPrice = 80,
                Capacity = 2,
                TruckType = "Pickup",
                FourWheelDrive = "Yes"
            };
           

            Motorcycle motorcycle = new Motorcycle
            {
                model = "R15",
                manufacturer = "Yamaha",
                year = 2020,
                rentalPrice = 30,
                engineCapacity = 500,
                fuelType = "Gasoline",
                hasFairing = "Yes"
            };


            agency.AddVehicle(car);
            agency.AddVehicle(truck);
            agency.AddVehicle(motorcycle);
            string model, manufacturer;
            int year;
            double rentalPrice;


            int input = 0;
            while (input < 5)
            {
                Console.WriteLine("Vehicle Rental Management System \n Please select one of the option below: \n 1. Add vehicle \n 2. Remove vehicle \n " +
                "3. Rent vehicle \n 4. Display vehicle");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Which vehicle do you want to add?(Car/Truck/Motorcycle)");
                        string vehicle = Console.ReadLine().ToLower();
                        Console.WriteLine("Enter Vehicle model:");
                        model = Console.ReadLine();

                        Console.WriteLine("Enter Vehicle manufacturer:");
                        manufacturer = Console.ReadLine();

                        Console.WriteLine("Enter Vehicle year:");
                        year = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Vehicle rentalPrice:");
                        rentalPrice = Convert.ToDouble(Console.ReadLine());
                        if (vehicle == "car")
                        {
                            car.model = model;
                            car.manufacturer = manufacturer;
                            car.year = year;
                            car.rentalPrice = rentalPrice;

                            car.Cardata();
                            agency.AddVehicle(car);

                        }
                        else if (vehicle == "truck")
                        {
                            truck.model = model;
                            truck.manufacturer = manufacturer;
                            truck.year = year;
                            truck.rentalPrice = rentalPrice;
                            truck.Truckdata();
                            agency.AddVehicle(truck);

                        }
                        else if (vehicle == "motorcycle")
                        {
                            motorcycle.model = model;
                            motorcycle.manufacturer = manufacturer;
                            motorcycle.year = year;
                            motorcycle.rentalPrice = rentalPrice;
                            motorcycle.Motorcycledata();
                            agency.AddVehicle(motorcycle);
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }

                        break;
                    case 2:
                        agency.Displayfleet();
                        Console.WriteLine("Enter the number of vehicle to be removed:");
                        int input1 = Convert.ToInt32(Console.ReadLine());
                        agency.RemoveVehicle(agency.fleet[input1 - 1]);
                        agency.Displayfleet();
                        break;
                    case 3:
                        agency.Displayfleet();
                        Console.WriteLine("Enter the number of vehicle to be rented:");
                        int rentvehicle = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("For how many days do you want to rent the vehicle");
                        int days = Convert.ToInt32(Console.ReadLine());
                        agency.RentVehicle(agency.fleet[rentvehicle - 1], days);
                        break;
                    case 4:
                        agency.Displayfleet();
                        break;

                }
            }


            //car.DisplayDetails();
            //truck.DisplayDetails();
            // motorcycle.DisplayDetails();

            //agency.RentVehicle(car, 3);
            // agency.RentVehicle(truck, 5);
            // agency.RentVehicle(motorcycle, 2);

            Console.WriteLine($"Total Revenue: {agency.totalRevenue} CAD");

        }
    }
}


