using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers;
using RestSharp;
using System.Reflection;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES
{
    static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Type> plugins = PluginLoader.GetPlugins();
            /*
            Debug.WriteLine("Count: " + plugins.Count);
            Debug.WriteLine("Calling GetJsonDataDict on Plugins");
            foreach(Type plugin in plugins)
            {
                Debug.WriteLine(plugin.FullName);
                object classInstance = Activator.CreateInstance(plugin, new object[] { });
                MethodInfo mi = plugin.GetMethod("GetJsonDataDict");
                Dictionary<string,string> result = (Dictionary<string, string>)mi.Invoke(classInstance, null);
                foreach(string val in result.Values)
                {
                    Debug.WriteLine(val);
                }
            }*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
