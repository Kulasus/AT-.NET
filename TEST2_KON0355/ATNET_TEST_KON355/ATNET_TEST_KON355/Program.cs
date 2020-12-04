using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace ATNET_TEST_KON355
{
    class Program
    {
        static void Main(string[] args)
        {
            using(FileSystemWatcher watcher = new FileSystemWatcher())
            {
                watcher.Path = @"D:\Coding\AT-.NET-GIT\TEST2_KON0355\ATNET_TEST_KON355\ATNET_TEST_KON355\Data\";

                watcher.Changed += OnChanged;
                watcher.Created += OnCreated;
                watcher.Deleted += OnDeleted;
                watcher.Renamed += OnRenamed;

                watcher.EnableRaisingEvents = true;
            }

            Console.ReadLine();
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            string url = "https://atnet.janjanousek.cz/watcher/";
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("name", e.Name);
            webClient.QueryString.Add("change", e.ChangeType.ToString());
            string response = webClient.DownloadString(url);
            var x = JObject.Parse(response);
            var status = x["status"].ToString();
            if (status == "ERROR")
            {
                throw new Exception();
            }
            Console.WriteLine($"File: {e.Name} changed");
        }

        private static void OnCreated(object source, FileSystemEventArgs e)
        {
            string url = "https://atnet.janjanousek.cz/watcher/";
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("name", e.Name);
            webClient.QueryString.Add("change", e.ChangeType.ToString());
            string response = webClient.DownloadString(url);
            var x = JObject.Parse(response);
            var status = x["status"].ToString();
            if (status == "ERROR")
            {
                throw new Exception();
            }
            Console.WriteLine($"File: {e.Name} created");
        }

        private static void OnDeleted(object source, FileSystemEventArgs e)
        {
            string url = "https://atnet.janjanousek.cz/watcher/";
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("name", e.Name);
            webClient.QueryString.Add("change", e.ChangeType.ToString());
            string response = webClient.DownloadString(url);
            var x = JObject.Parse(response);
            var status = x["status"].ToString();
            if (status == "ERROR")
            {
                throw new Exception();
            }
            Console.WriteLine($"File: {e.Name} deleted");
        }

        private static void OnRenamed(object source, RenamedEventArgs e) {
            string url = "https://atnet.janjanousek.cz/watcher/";
            WebClient webClient = new WebClient();
            webClient.QueryString.Add("name", e.OldName);
            webClient.QueryString.Add("change", e.ChangeType.ToString());
            string response = webClient.DownloadString(url);
            var x = JObject.Parse(response);
            var status = x["status"].ToString();
            if(status == "ERROR")
            {
                throw new Exception();
            }
            Console.WriteLine($"File: {e.OldFullPath} renamed to {e.FullPath}");
        }
    }
}
