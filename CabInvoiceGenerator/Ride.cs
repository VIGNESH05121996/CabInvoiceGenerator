using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;

        //Initilizing new instance of class Ride
        public Ride(double distance,int time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}
