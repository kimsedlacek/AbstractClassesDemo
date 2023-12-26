using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is driving abstract!");
        }


        public bool HasSideCart { get; set; }
        public string Mileage { get; set; }

        

        public override void DriveVirtual()
        {
            Console.WriteLine("rev and shift");
        }
    }
}
