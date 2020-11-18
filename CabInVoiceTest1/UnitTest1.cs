using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInVoiceTest1
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

        /// TC 2.1
        /// <sumary>
        /// Given the multiple rides should return invoice summary for normal ridetype.
        /// </summary>
        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            //initialising an instance
            //Arrange
            invoiceGenerator = new InVoiceGenerator(RideType.NORMAL);
            //passing values i.e distance and time through array 
            Ride[] rides =
            {
                new Ride(1.0, 1),
                new Ride(2.0, 2),
                new Ride(2.0, 2),
                new Ride(4.0, 4),
                new Ride(3.0, 3)
            };
            double expected = 132;
            //Act
            InVoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, summary.totalFare);
        }

        /// TC 2.2
        /// <summary>
        /// Given the multiple rides return invoice summary for premium ride type.
        /// </summary>
        [Test]
        public void GivenMultipleRides_ReturnInvoiceSummary()
        {
            //initialising an instance
            //Arrange
            invoiceGenerator = new InVoiceGenerator(RideType.PREMIUM);
            //passing values i.e distance and time through array 
            Ride[] rides =
            {
                new Ride(7.0, 1),
                new Ride(2.0, 3),
                new Ride(1.0, 2),
                new Ride(5.0, 4),
                new Ride(3.0, 3)
            };
            double expected = 297;
            //Act
            InVoiceSummary summary = invoiceGenerator.CalculateFare(rides);
            //Assert
            Assert.AreEqual(expected, summary.totalFare);
        }
    }
}