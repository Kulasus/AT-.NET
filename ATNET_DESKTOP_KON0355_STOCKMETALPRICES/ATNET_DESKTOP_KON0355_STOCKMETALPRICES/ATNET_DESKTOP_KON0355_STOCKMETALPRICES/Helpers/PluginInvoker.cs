using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers
{
    class PluginInvoker
    {
        public static void Invoke(List<Type> plugins)
        {
            foreach (Type plugin in plugins)
            {
                object classInstance = Activator.CreateInstance(plugin, new object[] { });
                MethodInfo mi = plugin.GetMethod("GetJsonDataDict");
                Dictionary<string, string> result = (Dictionary<string, string>)mi.Invoke(classInstance, null);
                foreach (string val in result.Values)
                {
                    Trace.WriteLine(val);
                }

                XmlService xmlService = new XmlService(plugin.Name);
                xmlService.WriteToXml(result);

            }
        }
    }
}
