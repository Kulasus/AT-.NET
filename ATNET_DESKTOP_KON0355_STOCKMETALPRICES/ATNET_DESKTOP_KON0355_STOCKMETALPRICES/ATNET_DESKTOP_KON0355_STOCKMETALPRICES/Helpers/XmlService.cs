using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Properties;
using System.Diagnostics;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers
{
    class XmlService
    {
        private static string xmlFilesPath = Application.StartupPath + Resources.XmlDirectoryName;
        private XmlDocument xmlDocument;
        private string fileName;
        public event EventHandler XmlWritten;

        public XmlService(string fileName)
        {
            this.fileName = fileName;
            xmlDocument = new XmlDocument();
            if (!File.Exists(xmlFilesPath + fileName + Resources.XmlSuffix))
            {
                XmlElement root = xmlDocument.CreateElement("root");
                xmlDocument.AppendChild(root);
                xmlDocument.Save(xmlFilesPath + fileName + Resources.XmlSuffix);
            }
            else
            {
                xmlDocument.Load(xmlFilesPath + fileName + Resources.XmlSuffix);
            }
        }

        public void WriteToXml(Dictionary<string, string> data)
        {
            XmlNode root = xmlDocument.SelectSingleNode("/root");
            XmlNode child = xmlDocument.CreateElement("record");

            XmlElement timestampXml = xmlDocument.CreateElement("timestamp");
            XmlElement currencyXml = xmlDocument.CreateElement("currency");
            XmlElement priceXml = xmlDocument.CreateElement("price");

            timestampXml.InnerText = data["timestamp"];
            currencyXml.InnerText = data["currency"];
            priceXml.InnerText = data["price"];

            child.AppendChild(timestampXml);
            child.AppendChild(currencyXml);
            child.AppendChild(priceXml);
            root.AppendChild(child);
            xmlDocument.Save(xmlFilesPath + fileName + Resources.XmlSuffix);
            OnXmlWritten(EventArgs.Empty);
        }

        public List<Dictionary<string,string>> LoadFromXml()
        {
            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();
            foreach (XmlNode node in xmlDocument.SelectNodes("/root/record"))
            {
                Dictionary<string, string> newDict = new Dictionary<string, string>();
                newDict.Add("timestamp", node["timestamp"].InnerText);
                newDict.Add("currency", node["currency"].InnerText);
                newDict.Add("price", node["price"].InnerText);
                result.Add(newDict);
            }
            return result;
        }

        public virtual void OnXmlWritten(EventArgs e)
        {
            XmlWritten?.Invoke(this, e);
        }
    }
}
