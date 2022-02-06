using Cab_invoice_Generator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoiceGenerator = null;

        [TestMethod]
        //step-1 test case
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }
        [TestMethod]

        public void GivenLessDistanceAndTime_ShouldReturnMinFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 0.1;
            int time = 1;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 5;
            Assert.AreEqual(expected, fare);
        }
        [TestMethod]
        //step-2 test case 
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            Ride[] rides = { new Ride(2.0, 5),
                new Ride(0.1, 1)
            };
            double fare = invoiceGenerator.CalculateFare(rides);
            double expected = 30;
            Assert.AreEqual(expected, fare);

        }

    }
}
