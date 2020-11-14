using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Xml.Linq;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.Downloader
{
    /// <summary>
    /// Used for downloading data from web
    /// </summary>
    static class DataDownloader
    {
        private static WebClient client = new WebClient();

        public static void DownloadFile(string source, string filePath)
        {
            client.DownloadFile(source, filePath);
        }

        public static void DownloadFile(string settingsPath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(settingsPath);
            string projectPath = xml.DocumentElement.SelectSingleNode("/info/projectPath").InnerText.ToString();
            string sourceAddress = xml.DocumentElement.SelectSingleNode("/info/downloadSource/address").InnerText.ToString();
            string fileName = xml.DocumentElement.SelectSingleNode("/info/downloadSource/fileName").InnerText.ToString();
            DownloadFile(sourceAddress, projectPath + @"\Resources\" + fileName + ".json");
        }
    }
}
