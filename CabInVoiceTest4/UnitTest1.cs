using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInVoiceTest4
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

        /// TC 5.1
        /// <summary>
        /// Given the normal ride type should return invoice.
        /// </summary>
        [Test]
        public void GivenNormal_RideType_ShouldReturnInvoice()
        {
            //Arrange
            double distance = 2.0;
            int time = 5;
            // Initializing the object with normal ride type
            invoiceGenerator = new InVoiceGenerator(RideType.NORMAL);
            // Invoking the Calculate Fare method to get the total actual fare
            //Act
            double totalActualFare = invoiceGenerator.CalculateFare(distance, time);
            double totalExpectedFare = 25.0;
            //Assert
            // Asserting with the expected value
            Assert.AreEqual(totalExpectedFare, totalActualFare);
        }

        /// TC 5.2
        /// <summary>
        /// Given the premium ride type should return invoice.
        /// </summary>
        [Test]
        public void GivenPremium_RideType_ShouldReturnInvoice()
        {
            //Arrange
            double distance = 2.0;
            int time = 5;
            // Initializing the object with normal ride type
            invoiceGenerator = new InVoiceGenerator(RideType.PREMIUM);
            // Invoking the Calculate Fare method to get the total actual fare
            //Act
            double totalActualFare = invoiceGenerator.CalculateFare(distance, time);
            double totalExpectedFare = 40.0;
            // Asserting with the expected value
            //Assert
            Assert.AreEqual(totalExpectedFare, totalActualFare);
        }
    }
}