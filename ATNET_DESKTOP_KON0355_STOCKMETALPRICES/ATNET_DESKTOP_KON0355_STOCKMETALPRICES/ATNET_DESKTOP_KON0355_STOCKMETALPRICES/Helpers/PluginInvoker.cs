using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Properties;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers
{
    class PluginInvoker
    {
        public static void Invoke(List<Type> plugins)
        {
            //Using one thread for each plugin
            List<Thread> threads = new List<Thread>();
            foreach (Type plugin in plugins)
            {
                threads.Add(new Thread(() => StartThread(plugin)));
            }
            foreach(Thread thread in threads) {
                Debug.WriteLine("Thread " + thread.ManagedThreadId + Resources.PluginInvokerThreadStartMessage);
                thread.Start();
            }
            foreach(Thread thread in threads)
            {
                Debug.WriteLine("Thread " + thread.ManagedThreadId + Resources.PluginInvokerThreadEndMessage);
                thread.Join();
            }
        }

        private static void StartThread(Type plugin)
        {
            object classInstance = Activator.CreateInstance(plugin, new object[] { });
            MethodInfo mi = plugin.GetMethod("GetJsonDataDict");
            Dictionary<string, string> result = (Dictionary<string, string>)mi.Invoke(classInstance, null);
            XmlService xmlService = new XmlService(plugin.Name);
            xmlService.XmlWritten += (sender, e) => xmlService_XmlWritten(sender, e, plugin.Name);
            xmlService.WriteToXml(result);
        }

        private static void xmlService_XmlWritten(object sender, EventArgs e, string pluginName)
        {
            Trace.WriteLine(Resources.PluginInvokerEventMessage + pluginName + Resources.XmlSuffix);
        }
    }
}
