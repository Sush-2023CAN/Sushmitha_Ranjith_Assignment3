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

       

    }
}

