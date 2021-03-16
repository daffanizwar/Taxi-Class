using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Taxi taxi = new Taxi();

            taxi.Driver = "Jono";
            taxi.onDuty = true;
            taxi.NumPass = 10;


            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
