using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_invoice_Generator
{
    /// <summary>
    /// step-2 mutiple rides
    /// </summary>
   public class Ride
    {
        public double distance;
        public int time;
        public string rideType;
        public Ride(double inputdistance, int inputtime, string inputRideType = "normal")
        {
            this.distance = inputdistance;
            this.time = inputtime;
            this.rideType = inputRideType;
        }
    }
}
