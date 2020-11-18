using System;

namespace CabInvoiceGenerator
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Cab Invoice Generator!");
            //initializing instance for invoice class
            InVoiceGenerator invoiceGenerator = new InVoiceGenerator(RideType.NORMAL);
            //calculates the fare
            double fare = invoiceGenerator.CalculateFare(2.0, 5);
            Console.WriteLine($"Fare : {fare}");

        }
    }
}
