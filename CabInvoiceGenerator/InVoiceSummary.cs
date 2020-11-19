using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InVoiceSummary
    {
        //variables
        public int numberOfRides;
        public double totalFare;
        public double averageFare;
        public int length;

        /// <summary>
        /// Initializes a new instance of the <see cref="InVoiceSummary"/> class.
        /// </summary>
        /// <param name="numberofRides">The numberof rides.</param>
        /// <param name="totalFare">The total fare.</param>
        public InVoiceSummary(double totalFare, int length)
        {
            this.totalFare = totalFare;
            this.length = length;
        }

        /// <summary>
        /// Values the tuple.
        /// </summary>
        /// <typeparam name="Double">The type of the ouble.</typeparam>
        /// <typeparam name="Int32">The type of the NT32.</typeparam>
        /// <typeparam name="Double">The type of the ouble.</typeparam>
        /// <returns></returns>
        public InVoiceSummary(double totalFare, int length, double averageFare)
        {
            this.totalFare = totalFare;
            this.length = length;
            this.averageFare = averageFare;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        // Over riding the Equals method so as to match the value of the object references
        // Default Equals method comapre the reference of the objects and not the values
        public override bool Equals(object obj)
        {
            //checks object is not null
            if (obj == null) return false;
            //checks if object is equal to invoice summary or not
            if (!(obj is InVoiceSummary)) return false;
            //converting object into invoice summary type
            InVoiceSummary inputedObject = (InVoiceSummary)obj;
            //returns value after comparing with both objects
            return this.numberOfRides == inputedObject.numberOfRides && this.totalFare == inputedObject.totalFare && this.averageFare == inputedObject.averageFare;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        // Overriding equals method require overriding the GetHashCode method also
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}