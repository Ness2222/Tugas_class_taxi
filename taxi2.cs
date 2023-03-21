using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi_class_object
{
    public class taxi2
    {
        public string Drivernama { get; set;}
            public Boolean Onduty {get; set;}
            public int Numpassenger { get; set;}

        public void Taxiinfo()
        {
            Console.WriteLine("Drivernama: {0}", Drivernama);
            if (Onduty == true)
            {
                Console.WriteLine("On duty : yes");
            }
            else if (Onduty == false)
			{
                Console.WriteLine("On duty : no");
            }
            Console.WriteLine("Numpassenger: {0}", Numpassenger);
        }


        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", Drivernama);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", Drivernama);
        }
    }
}
