using System;

namespace ExtraFunctions
{
    /// <summary>
    /// Represents exception that occurs when two or more controls gets assigned same data.
    /// </summary>
    class MutualExclusionException : Exception
    {
        string meeMessage;

        /// <summary>
        /// Initializes a new instance of MutualExclusionException class.
        /// </summary>
        public MutualExclusionException()
        {
            meeMessage = "Two or more controls cannot be set same value in custom mutual exclusion.";
        }

        /// <summary>
        /// Initializes a new instance of MutualExclusionException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the exception.</param>
        public MutualExclusionException(string message)
        {
            meeMessage = message;
        }

        /// <summary>
        /// Initializes a new instance of MutualExclusionException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
        public MutualExclusionException(string message, Exception innerException)
        {
            meeMessage = message;
        }

        public override string Message
        {
            get
            {
                return meeMessage;
            }
        }

        public override string Source
        {
            get
            {
                return base.Source;
            }
            set
            {
                base.Source = value;
            }
        }
        public override string StackTrace
        {
            get
            {
                return base.StackTrace;
            }
        }

        public override string ToString()
        {
            string res = Source + "MutualExclusionException : " + meeMessage + " at " + TargetSite.ToString();
            return res;
        }
        
    }
}
