using System;
using System.Collections.Generic;
using System.Text;

namespace SWAPI_TestCs.src
{
    class IDnotFoundException : Exception
    {
        public IDnotFoundException() : base() { }
        public IDnotFoundException(string message): base(message) { }
        public IDnotFoundException(string message, Exception e) : base(message, e) { }
    }
}
