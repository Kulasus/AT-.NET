using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class TextLogger : ILogger
    {
        public async Task Log(Exception e)
        {
            await File.WriteAllTextAsync("log.txt", e.StackTrace);
        }
    }
}
