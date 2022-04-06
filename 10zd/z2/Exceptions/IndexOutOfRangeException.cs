using System;

namespace z2.Exceptions
{
    internal class IndexOutOfRangeException : Exception
    {
        public string Comment { get; }
        public IndexOutOfRangeException(string comment = "Error")
        {
            Comment = comment;
        }

        public IndexOutOfRangeException(string message, string comment = "Error") :base(message)
        {
        }
    }
}
