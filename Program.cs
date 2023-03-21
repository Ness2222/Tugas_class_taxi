using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace Taxi_class_object
{
    class program
    {

        static void Main(string[] args)
        {
            taxi2 taxi = new taxi2();

            taxi.Drivernama = "Jono";
            taxi.Onduty = true;
            taxi.Numpassenger = 10;

            taxi.Taxiinfo();

            Console.WriteLine();

            taxi.PickUpPassanger();
            taxi.DropOffPassenger();

            Console.ReadKey();

        }
    }
}

