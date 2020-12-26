using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATNET_WEBAPP_KON0355.Exceptions
{
    public class ShowNotFoundException : Exception
    {
        public ShowNotFoundException()
        {

        }

        public ShowNotFoundException(string message) : base(message)
        {

        }

        public ShowNotFoundException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
