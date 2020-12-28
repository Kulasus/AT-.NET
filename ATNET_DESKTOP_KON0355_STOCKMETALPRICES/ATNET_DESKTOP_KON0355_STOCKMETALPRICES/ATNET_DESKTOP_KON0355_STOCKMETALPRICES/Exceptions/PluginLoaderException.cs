using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Exceptions
{
    class PluginLoaderException : Exception
    {
        public PluginLoaderException() { }

        public PluginLoaderException(string message) : base(message) { }

        public PluginLoaderException(string message, Exception inner) : base(message, inner) { }
    }
}
