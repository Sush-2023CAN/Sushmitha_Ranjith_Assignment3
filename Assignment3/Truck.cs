using System;



public class Truck : Vehicle;
{
    private int Capacity { get; set; }
    private string TruckType { get; set; }
    private bool FourWheelDrive { get; set; }
    DisplayDetails(int Capacity, string TruckType, bool FourWheelDrive);
}
