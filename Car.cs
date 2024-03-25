
    public class Car : Vehicle
    {
        private int seats;
        private string engineType;
        private string transmission;
        private bool convertible;


    public void Cardata()
    {
        Console.WriteLine("Enter number of seats:");
        seats = Console.ReadLine();

        Console.WriteLine("Enter car engineType:");
        engineType = Console.ReadLine();

        Console.WriteLine("Enter car transmission:");
        transmission = Console.ReadLine();

        Console.WriteLine("Enter car convertible:");
        convertible = Console.ReadLine();
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
            base.DisplayDetails();
            Console.WriteLine($" Model: {model}, Manufacturerer: {manufacturer}, Year: {year}, RentalPrice: {}Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {(Convertible ? "Yes" : "No")}");
        }
    }

