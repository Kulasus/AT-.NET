using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers;

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
            //ApiClient apiClient = new ApiClient("XAU", "CZK");
            //Debug.WriteLine("response.Content");
            //Debug.WriteLine(apiClient.GetJsonString());
            PluginLoader.GetPlugins();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
