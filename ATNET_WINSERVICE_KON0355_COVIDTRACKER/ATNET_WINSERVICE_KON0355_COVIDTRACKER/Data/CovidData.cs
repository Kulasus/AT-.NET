using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml;
using ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data
{
    /// <summary>
    /// Represents file downloaded from web
    /// </summary>
    class CovidData
    {
        /// <summary>
        /// Last time the file was modified
        /// </summary>
        private DateTime modified { get; set; }

        /// <summary>
        /// Source of data from file
        /// </summary>
        private string source { get; set; }

        /// <summary>
        /// All days in file
        /// </summary>
        private LinkedList<CovidDay> data { get; set; }

        /// <summary>
        /// Used for deserialization of json to C# object
        /// </summary>
        public static CovidData LoadJson()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Session.settingsPath);
            string fileName = xml.SelectSingleNode("/info/downloadSource/fileName").InnerText.ToString();

            using (StreamReader file = File.OpenText(Session.projectPath + @"\Resources\" + fileName + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                return (CovidData)serializer.Deserialize(file, typeof(CovidData));
            }
        }

    }
}
