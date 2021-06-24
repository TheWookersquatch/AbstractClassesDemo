using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles




            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car sedan = new Car()
            {
                Year = "2003",
                Make = "Honda",
                Model = "Accord"
            };
            Motorcycle scooter = new Motorcycle()
            {
                Year = "2009",
                Make = "Yamaha",
                Model = "C3"
            };
            Vehicle van = new Car()
            {
                Year = "2010",
                Make = "Toyota",
                Model = "Sienna", 
                NumSeats = 7 
            } ;
           
            Vehicle bike = new Motorcycle() 
            { 
                Year = "2021", 
                Make = "Ducati", 
                Model = "Monster", 
                NeedHelmet = true 
            };


            // Add the 4 vehicles to the list
            vehicles.Add(sedan);
            vehicles.Add(scooter);
            vehicles.Add(van);
            vehicles.Add(bike);
            // Using a foreach loop iterate over each of the properties
            foreach (Vehicle vehicle in vehicles)
            {
                Type type = typeof(Vehicle);
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    Console.WriteLine($"{property.Name} = {property.GetValue(vehicle, null)}");
                }
            }


            // Call each of the drive methods for one car and one motorcycle
            van.DriveAbstract();
            van.DriveVirtual();
            scooter.DriveVirtual();
            scooter.DriveAbstract();


            #endregion            
           
        }
    }
}
