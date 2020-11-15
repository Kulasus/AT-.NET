using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Downloader;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.EmailService;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Graph;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER
{
    static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new CovidTrackerService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
