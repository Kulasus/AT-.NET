using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Downloader;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.EmailService;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Graph;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        static void Main()
        {
            DataDownloader.DownloadFile(Session.settingsPath);
            CovidData data = CovidData.LoadJson();
            GraphGenerator.GenerateGraph(2500,2500,data.getNewCasesForDays(30));
            //EmailSender.sendMail();
            /*ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new CovidTrackerService()
            };
            ServiceBase.Run(ServicesToRun);*/
        }
    }
}
