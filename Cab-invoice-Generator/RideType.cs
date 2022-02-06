﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_invoice_Generator
{
    class RideType
    {
        public static readonly string normalRide = "normal";
        public static readonly string premiumRide = "premium";
        public readonly int costPerTime;
        public readonly double minimumCostPerKilometer;
        public readonly double minimumFare;

        public RideType(string rideType)
        {
            if (rideType.ToLower() == premiumRide)
            {
                costPerTime = 2;
                minimumCostPerKilometer = 15;
                minimumFare = 20;
            }
            else
            {
                costPerTime = 1;
                minimumCostPerKilometer = 10;
                minimumFare = 5;
            }
        }
    }
}


