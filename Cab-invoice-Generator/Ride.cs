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

        public Ride(double inputdistance, int inputtime)
        {
            this.distance = inputdistance;
            this.time = inputtime;
        }
    }
}
