using System;

public class Motorcycle: Vehicle;
{
	private int EngineCapacity { get; set; };
	private string FuelType { get; set; }
	private bool HasFairing { get; set;}
	DisplayDetails(int capacity);
}
