using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_invoice_Generator
{
  public   class InvoiceGenerator
    {
        //uc-1 calculating total fare
        private double CostPerTime = 1;
        private static readonly double Min_Cost_Per_Km = 10;
        private double Minimum_Fare = 5;
        public double CalculateFare(double distance, int time, string type = "normal")
        {
            double totalFare = distance * Min_Cost_Per_Km + time * CostPerTime;
            if (totalFare < Minimum_Fare)
            {
                return Minimum_Fare;
            }
            return totalFare;
        }
        //step-2 Multiple Rides added 
        //public double CalculateFare(Ride[] rides)
        //{
        //    double totalFare = 0;
        //    foreach (Ride ride in rides)
        //    {
        //        totalFare += this.CalculateFare(ride.distance, ride.time);
        //    }
        //    return totalFare;
        //}
        //step-3 Enhanced invoice
        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            int numberOfRides = 0;
            double averageFare = 0;
            InvoiceSummary invoiceSummary = new InvoiceSummary();
            foreach (Ride ride in rides)
            {
                totalFare += this.CalculateFare(ride.distance, ride.time);
                numberOfRides++;
            }
            invoiceSummary.TotalNumberOfRides = numberOfRides;
            invoiceSummary.TotalFare = totalFare;
            invoiceSummary.CalculateAvergaeFare();
            return invoiceSummary;
        }
        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (UserAccount.account.ContainsKey(userId))
            {
                double totalFare = 0;
                int numberOfRides = 0;
                InvoiceSummary invoiceSummary = new InvoiceSummary();
                foreach (Ride ride in UserAccount.account[userId])
                {
                    totalFare += this.CalculateFare(ride.distance, ride.time, ride.rideType);
                    numberOfRides++;
                }
                invoiceSummary.TotalNumberOfRides = numberOfRides;
                invoiceSummary.TotalFare = totalFare;
                invoiceSummary.CalculateAvergaeFare();
                return invoiceSummary;
            }
            else
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "INVALID_USER_ID");
            }

        }
    }
}
