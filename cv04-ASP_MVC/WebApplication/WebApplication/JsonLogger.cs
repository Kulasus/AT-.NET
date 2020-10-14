using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplication
{
    public class JsonLogger : ILogger
    {
        public async Task Log(Exception e)
        {
            await File.WriteAllTextAsync("log.json", JsonConvert.SerializeObject(new
            {
                StackTrace = e.StackTrace,
                Message = e.Message
            }));
        }
    }
}
