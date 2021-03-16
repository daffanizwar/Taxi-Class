using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_Class
{
    class Taxi
    {
        public string Driver { get; set; }
        public bool onDuty { get; set; }
        public int NumPass { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", Driver);
            Console.WriteLine("On Duty : {0}", onDuty);
            Console.WriteLine("Number of Passenger : {0}", NumPass);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", Driver);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", Driver);
        }
           
    }
}
