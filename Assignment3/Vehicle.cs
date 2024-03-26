namespace Assignment3
{
    public abstract class Vehicle
    {
        public string model;
        public string manufacturer;
        public int year;
        public double rentalPrice;


       

        /* public string Model
         {
             get { return model; }
             set { model = value; }
         }

         public string Manufacturer
         {
             get { return manufacturer; }
             set { manufacturer = value; }
         }

         public int Year
         {
             get { return year; }
             set { year = value; }
         }

         public decimal RentalPrice
         {
             get { return rentalPrice; }
             set { rentalPrice = value; }
         }*/

        public abstract void DisplayDetails();

    }
}

