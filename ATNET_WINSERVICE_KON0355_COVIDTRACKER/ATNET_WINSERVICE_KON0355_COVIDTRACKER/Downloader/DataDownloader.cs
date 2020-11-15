using System.Net;
using System.Xml;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;

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
            string sourceAddress = xml.DocumentElement.SelectSingleNode("/info/downloadSource/address").InnerText.ToString();
            string fileName = xml.DocumentElement.SelectSingleNode("/info/downloadSource/fileName").InnerText.ToString();
            DownloadFile(sourceAddress, Session.projectPath + @"\Resources\" + fileName + ".json");
        }
    }
}
