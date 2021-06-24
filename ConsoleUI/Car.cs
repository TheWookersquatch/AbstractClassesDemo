using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Car : Vehicle
    {
        public Car()
        {

        }
        public Car(string year = "0000", string make = "Make", string model = "Model", int numSeats = 5)
        {
            Year = year;
            Make = make;
            Model = model;
            NumSeats = numSeats;
        }
        public  int NumSeats { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"You are driving in your {Year} {Make} {Model}.");
        }
    }
}
