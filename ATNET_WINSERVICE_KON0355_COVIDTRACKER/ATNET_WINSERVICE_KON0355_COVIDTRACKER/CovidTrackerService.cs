using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Downloader;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.EmailService;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Graph;
using System.Timers;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER
{
    public partial class CovidTrackerService : ServiceBase
    {
        Timer timer = new Timer();

        public CovidTrackerService()
        {
            InitializeComponent();
            timer.Interval = 360000; //Ten minutes
            timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
        }

        protected override void OnStart(string[] args)
        {
            DataDownloader.DownloadFile(Session.settingsPath);
            CovidData data = CovidData.LoadJson();
            GraphGenerator.GenerateGraph(1200, 1200, data.getNewCasesForDays(14));
            EmailSender.sendMail();
            timer.Start();
        }

        public void OnTimer(object sender, ElapsedEventArgs args)
        {
            DataDownloader.DownloadFile(Session.settingsPath);
            CovidData data = CovidData.LoadJson();
            GraphGenerator.GenerateGraph(1200, 1200, data.getNewCasesForDays(14));
            EmailSender.sendMail();
        }

        protected override void OnStop()
        {
            timer.Stop();
        }

        protected override void OnContinue()
        {
            DataDownloader.DownloadFile(Session.settingsPath);
            CovidData data = CovidData.LoadJson();
            GraphGenerator.GenerateGraph(1200, 1200, data.getNewCasesForDays(14));
            EmailSender.sendMail();
            timer.Start();
        }
    }
}
