using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public Motorcycle(string year = "0000", string make = "Make", string model = "Model", bool needHelmet = true)
        {
            Year = year;
            Make = make;
            Model = model;
            NeedHelmet = needHelmet;
        }
        // Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
        public bool NeedHelmet { get; set; }
        // Provide the implementations for the abstract methods
        // Only in the Motorcycle class will you override the virtual drive method
         
        public override void DriveAbstract()
        {
            Console.WriteLine($"You are driving your {Year} {Make} {Model}.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Driving on your {Year} {Make} {Model}.");
        }
    }
}
