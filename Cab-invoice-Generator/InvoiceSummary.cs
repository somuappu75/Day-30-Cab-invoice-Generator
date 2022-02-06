using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_invoice_Generator
{
    public class InvoiceSummary
    {
        //step-3 
        public int TotalNumberOfRides { get; set; }
        public double TotalFare { get; set; }
        public double AverageFarePerRide { get; set; }

        public void CalculateAvergaeFare()
        {
            AverageFarePerRide = TotalFare / TotalNumberOfRides;
        }

    }
}
