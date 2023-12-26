using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles



            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             *
             * Set the properties values with object initializer syntax
             */

            var car = new Car()
            {
              HasTrunk = true,
              Year = "2020",
              Make = "Toyota",
              Model = "Camry"
            };
            vehicles.Add(car);


            var motorcycle = new Motorcycle()
            {
                HasSideCart = false,
                Year = "2020",
                Make = "Honda",
                Model = "Night Hawk"
            };
            vehicles.Add(motorcycle);

            Vehicle auto1 = new Car()
            {
                HasTrunk = true,
                Year = "2010",
                Make = "Ford",
                Model = "Explorer"
            };
            vehicles.Add(auto1);

            Vehicle auto2 = new Motorcycle()
            {
                HasSideCart = true,
                Year = "2014",
                Make = "Yamaha",
                Model = "1500"
            };
            vehicles.Add(auto2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This is a {vehicle.Year}, {vehicle.Make} {vehicle.Model}.");
               
            }
            car.DriveAbstract();
            car.DriveVirtual();
            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
