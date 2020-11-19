using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInVoiceTest3
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

        /// TC 4
        /// <summary>
        /// Given the user identifier should return invoice summary.
        /// </summary>
        public void GivenUserId_ShouldReturnInvoiceSummary()
        {
            //ARRANGE
            // initialising the object of the invoice generator class
            invoiceGenerator = new InVoiceGenerator(RideType.NORMAL);
            // Creating the object of the ride repository
            RideRepository repository = new RideRepository();
            // Initialising the user ID
            string userID = "Ramya";
            // Initialising the ride array with details of the ride
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };
            // Adding the ride data for the user to the ride repository
            repository.AddRide(userID, rides);
            // Getting the ride data from the ride repository class using the user ID
            Ride[] rideData = repository.GetRides(userID);
            // Getting the invoice summary when passing the ride Data
            InVoiceSummary invoiceSummary = invoiceGenerator.CalculateAvgFare(rideData);
            //ACT
            // Expected value of the Invoice Summary
            InVoiceSummary expectedInvoiceSummary = new InVoiceSummary(30.0, 2, 15.0);
            //ASSERT
            // Asserting the comparison between the expected and actual invoice summary
            Assert.AreEqual(expectedInvoiceSummary, invoiceSummary);
        }
    }
}
