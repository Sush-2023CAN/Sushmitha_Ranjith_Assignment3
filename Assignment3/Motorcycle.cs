
using System;

namespace Assignment3
{
    public class Motorcycle : Vehicle
    {
        public int engineCapacity;
        public string fuelType;
        public string hasFairing;

        public void Motorcycledata()
        {
            Console.WriteLine("Enter engineCapacity:");
            engineCapacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fuelType:");
            fuelType = Console.ReadLine();

            Console.WriteLine("Enter motorcycle hasFairing:");
            hasFairing = (Console.ReadLine());

        }



        public override void DisplayDetails()
        {
            
            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {rentalPrice} \n Engine Capacity: {engineCapacity}cc, Fuel Type: {fuelType}, Has Fairing: {hasFairing}");
        }
    }
}

