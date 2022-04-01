using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3.Exceptions
{
    internal class OutOfDiapazonException : Exception
    {
        public string Comment { get; }
        public OutOfDiapazonException(string comment = "Error")
        {
            Comment = comment;
        }

        public OutOfDiapazonException(string message, string comment = "Error") : base(message)
        {
        }
    }
}
