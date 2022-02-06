using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_invoice_Generator
{
   public class InvoiceGenerator
    {
        //uc-1 calculating total fare
        private double CostPerTime = 1;
        private static readonly double Min_Cost_Per_Km= 10;
        private double Minimum_Fare = 5;
        public double CalculateFare(double distance, int time)
        {
            double totalFare = distance * Min_Cost_Per_Km + time * CostPerTime;
            if (totalFare < Minimum_Fare)
            {
                return Minimum_Fare;
            }
            return totalFare;
        }
    }
}
