using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public Vehicle()
        {

        }
     
        // The vehicle class shall have three string properties Year, Make, and Model
        public  string Year { get; set; }
        public  string Make { get; set; }
        public string Model { get; set; }
        // Set the defaults to something generic in the Vehicle class
        // Vehicle shall have an abstract method called DriveAbstract with no implementation
        public abstract void DriveAbstract();
        // Vehicle shall have a virtual method called DriveVirtual with a base implementation.
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Driving in your {Year} {Make} {Model}.");
        }


    }
}
