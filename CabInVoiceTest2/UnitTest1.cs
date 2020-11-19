using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInVoiceTest2
{
    public class Tests
    {
        //initialising instance for invoice generator
        InVoiceGenerator invoiceGenerator;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        /// TC 3
        /// <summary>
        /// Given the multiple rides should return invoice summary for average fare for normal ridetype
        /// </summary>
        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary_WithAverage()
        {
            // Arrange
            invoiceGenerator = new InVoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            // Act
            InVoiceSummary invoiceSummary = invoiceGenerator.CalculateAvgFare(rides);
            // if both the objects are equal then get the same HashCode for both the objects
            var resultHashCode = invoiceSummary.GetHashCode();
            InVoiceSummary expectedInvoiceSummary = new InVoiceSummary(30.0, 2, 15.0);
            var resulExpectedHashCode = expectedInvoiceSummary.GetHashCode();
            // Assert
            Assert.AreEqual(expectedInvoiceSummary, invoiceSummary);
        }
    }
}
      