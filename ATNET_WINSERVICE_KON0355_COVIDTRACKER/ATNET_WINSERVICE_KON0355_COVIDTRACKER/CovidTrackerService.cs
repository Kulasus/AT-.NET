using System.ServiceProcess;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Downloader;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.EmailService;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Graph;

using System.Threading;
using System;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER
{
    public partial class CovidTrackerService : ServiceBase
    {
        Timer timer;

        public CovidTrackerService()
        {
            InitializeComponent();
            timer = new Timer(OnTimer,null,Timeout.Infinite,Timeout.Infinite);
        }

        protected void OnTimer(object state)
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            DataDownloader.DownloadFile(Session.settingsPath);
            CovidData data = CovidData.LoadJson();
            GraphGenerator.GenerateGraph(1200, 1200, data.getNewCasesForDays(14));
            EmailSender.sendMail();
            timer.Change(3600000, Timeout.Infinite);
        }

        protected override void OnStart(string[] args)
        {
            DataDownloader.DownloadFile(Session.settingsPath);
            CovidData data = CovidData.LoadJson();
            GraphGenerator.GenerateGraph(1200, 1200, data.getNewCasesForDays(14));
            EmailSender.sendMail();
            timer.Change(3600000, Timeout.Infinite);
        }


        protected override void OnStop()
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        protected override void OnContinue()
        {
            DataDownloader.DownloadFile(Session.settingsPath);
            CovidData data = CovidData.LoadJson();
            GraphGenerator.GenerateGraph(1200, 1200, data.getNewCasesForDays(14));
            EmailSender.sendMail();
            timer.Change(3600000, Timeout.Infinite);
        }
    }
}
