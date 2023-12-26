using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Car is driving abstract!");
        }


        public bool HasTrunk { get; set; }

        public string Mileage { get; set; }

        
    }
}
