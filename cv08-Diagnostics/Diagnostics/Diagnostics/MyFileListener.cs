using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace Diagnostics
{
    class MyFileListener : TraceListener
    {
        public override void Write(string message)
        {
            File.AppendAllText("./log.txt", message);
        }
        public override void WriteLine(string message)
        {
            this.Write(message + "\n");
        }
    }
}
