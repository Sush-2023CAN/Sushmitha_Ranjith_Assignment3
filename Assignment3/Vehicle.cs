﻿using System;
namespace Vehicle {
public class Vehicle
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public int RentalPrice { get; set; }
    public void DisplayDetails(int Model, string Manufacturer, int Year, int RentalPrice)
    {
            Console.WriteLine("Type the model")
            Model= Console.ReadLine();

    }
}
}