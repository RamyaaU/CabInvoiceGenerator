using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Class for custom exception handling
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class CabInVoiceException : Exception
    {
        //declaring enum variables
        public enum ExceptionType
        {
            INVALID_RIDE_TYPE,
            INVALID_DISTANCE,
            INVALID_TIME,
            NULL_RIDES,
            INVALID_USER_ID
        }

        /// <summary>
        /// The type of exception
        /// </summary>
        ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="CabInVoiceException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public CabInVoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

