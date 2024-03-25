
    public abstract class Vehicle
    {
        public string model;
        public string manufacturer;
        public int year;
        public decimal rentalPrice;


    public void Vehicledata()
    {
        Console.WriteLine("Enter Vehicle model:");
        model= Console.ReadLine();

        Console.WriteLine("Enter Vehicle manufacturer:");
        manufacturer = Console.ReadLine();

        Console.WriteLine("Enter Vehicle year:");
        year = Console.ReadLine();

        Console.WriteLine("Enter Vehicle rentalPrice:");
        rentalPrice = Console.ReadLine();
    }

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

