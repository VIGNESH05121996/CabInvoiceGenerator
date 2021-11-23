using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        //get totalfare for one trip
        [TestMethod]
        [TestCategory("Fare")]
        public void GivenDistanceAndTimeShouldReturnTotalFare()
        {
            double expected = 17;
            double distance = 2.0;
            int time = 5;

            InvoiceGenerator invoice = new InvoiceGenerator(RideType.NORMAL);

            //calculating fare
            double fare = invoice.calculateFare(distance, time);

            Assert.AreEqual(expected, fare);
        }

        //get totalfare for multiple trip
        [TestMethod]
        [TestCategory("Fare")]
        public void GivenMultipleRidesReturnTotalFare()
        {
            //creating instance of invoice generator
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.PREMIUM);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            InvoiceSummary expected = new InvoiceSummary(rides.Length, 60);

            InvoiceSummary actual = invoiceGenerator.CalculateFare(rides);
            actual.Equals(expected);
        }
    }
}
