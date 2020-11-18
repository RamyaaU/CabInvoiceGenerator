using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInVoiceTest
{
    public class Tests
    {
        //initialising instance for invoice generator
        InVoiceGenerator invoiceGenerator; 

        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test1s this instance.
        /// </summary>
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        /// TC 1.1
        /// <summary>
        /// Given the distance and time return total fare for normal ridetype
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            //initialising an instance
            invoiceGenerator = new InVoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            //Arrange
            double expected = 25;
            //Assert
            Assert.AreEqual(expected, fare);
        }

        /// <summary>
        /// Givens the distance and time return total fare for premium ridetype
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ReturnTotalFare()
        {
            //initialising an instance
            invoiceGenerator = new InVoiceGenerator(RideType.PREMIUM);
            double distance = 4.0;
            int time = 5;
            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            //Arrange
            double expected = 70;
            //Assert
            Assert.AreEqual(expected, fare);
        }
    }
}