

using System;

namespace Assignment3
{
    public class Truck : Vehicle
    {
        private int capacity;
        private string truckType;
        private string fourWheelDrive;




        public void Truckdata()
        {
            Console.WriteLine("Enter the capacity:");
            capacity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the truckType:");
            truckType = Console.ReadLine();

            Console.WriteLine("Enter if fourWheelDrive:");
            fourWheelDrive = (Console.ReadLine());
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string TruckType
        {
            get { return truckType; }
            set { truckType = value; }
        }

        public string FourWheelDrive
        {
            get { return fourWheelDrive; }
            set { fourWheelDrive = value; }
        }

        public override void DisplayDetails()
        {
          
            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {rentalPrice} \n Capacity: {Capacity} tons, Truck Type: {TruckType}, Four-Wheel Drive: {(fourWheelDrive)}");
        }
    }
}

