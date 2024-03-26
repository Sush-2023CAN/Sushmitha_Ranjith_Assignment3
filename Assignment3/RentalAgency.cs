namespace Assignment3
{
    public class RentalAgency
    {
        public Vehicle[] fleet;
        public int count;
        public double totalRevenue;

        public RentalAgency(int capacity)
        {
            fleet = new Vehicle[capacity];
            count = 0;
            totalRevenue = 0;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (count < fleet.Length)
            {
                fleet[count++] = vehicle;
            }
            else
            {
                Console.WriteLine("Fleet is full. Cannot add more vehicles.");
            }
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            int index = Array.IndexOf(fleet, vehicle);
            if (index >= 0)
            {
                // Shift elements to the left to remove the vehicle
                for (int i = index; i < count - 1; i++)
                {
                    fleet[i] = fleet[i + 1];
                }
                count--;
            }
            else
            {
                Console.WriteLine("Vehicle not found in fleet.");
            }
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (Array.IndexOf(fleet, vehicle) >= 0)
            {
                totalRevenue += vehicle.rentalPrice * days;
                Console.WriteLine($"Vehicle rented for {days} days. Total cost: {vehicle.rentalPrice * days} CAD");
            }
            else
            {
                Console.WriteLine("Vehicle not found in fleet.");
            }

        }
        public void Displayfleet()
        {
            for (int i = 0; i < count; i++)
            {
                fleet[i].DisplayDetails();
            }

        }



    }
}

