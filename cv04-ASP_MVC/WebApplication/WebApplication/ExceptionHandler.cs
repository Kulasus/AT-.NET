using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication
{
    public class ExceptionHandler
    {
        private ILogger logger;
        public ExceptionHandler(ILogger logger)
        {
            this.logger = logger;
        }
        public async Task Handle(Exception e)
        {
            await logger.Log(e);
        }
    }
}
