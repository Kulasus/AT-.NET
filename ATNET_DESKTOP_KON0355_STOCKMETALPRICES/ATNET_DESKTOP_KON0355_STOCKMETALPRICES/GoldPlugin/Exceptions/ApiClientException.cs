using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldPlugin.Exceptions
{
    class ApiClientException : Exception
    {
        public ApiClientException() { }

        public ApiClientException(string message) : base(message) { }

        public ApiClientException(string message, Exception inner) : base(message, inner) { }
    }
}
