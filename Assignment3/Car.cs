namespace Car

{
    class Car: Vehicle;
    {
        public int Seats { get; set; }
        private string EngineType { get; set; }
        private int Transmission { get; set; }
        private bool Convertible { get; set; }

        public void DisplayDetails(int Seats, string EngineType, int Transmission, int Convertible)
        {

        }
    }
}