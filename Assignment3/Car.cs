
namespace Assignment3
{
    class Car : Vehicle
    {
        public int seats;
        public string engineType;
        public string transmission;
        public string convertible;


        public void Cardata()
        {
            Console.WriteLine("Enter number of seats:");
            seats = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car engineType:");
            engineType = Console.ReadLine();

            Console.WriteLine("Enter car transmission:");
            transmission = Console.ReadLine();

            Console.WriteLine("Enter car convertible:");
            convertible = (Console.ReadLine());
        }




        /*public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public string EngineType
        {
            get { return engineType; }
            set { engineType = value; }
        }

        public string Transmission
        {
            get { return transmission; }
            set { transmission = value; }
        }

        public bool Convertible
        {
            get { return convertible; }
            set { convertible = value; }
        }*/



        public override void DisplayDetails()
        {
            
            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {rentalPrice}Seats: {seats}, Engine Type: {engineType}, Transmission: {transmission}, Convertible: {(convertible)}");
        }
    }
}

