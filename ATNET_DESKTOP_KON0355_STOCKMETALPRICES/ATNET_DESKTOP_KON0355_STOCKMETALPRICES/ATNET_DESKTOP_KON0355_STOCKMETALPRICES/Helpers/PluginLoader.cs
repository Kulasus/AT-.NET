using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using SharedContext;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Properties;
using ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Exceptions;

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers
{
    public static class PluginLoader
    {
        private static string pluginsDirectoryPath = Application.StartupPath + Resources.PluginsDirectoryPath;
        private static string[] plugins = Directory.GetFiles(pluginsDirectoryPath, Resources.PluginsSuffix);

        public static List<Type> GetPlugins()
        {
            List<Type> validTypes = new List<Type>();
            foreach(string s in plugins)
            {
                Assembly assembly = Assembly.LoadFile(s);
                List<Type> allPluginTypes = assembly.GetTypes().ToList();
                try
                {
                    List<Type> validPluginTypes = GetValidTypes(allPluginTypes);
                    validTypes.AddRange(validPluginTypes);
                }
                catch (PluginLoaderException e){
                    Trace.WriteLine(e.Message);
                }
            }
            return validTypes;
        }

        private static List<Type> GetValidTypes(List<Type> types)
        {
            List<Type> validTypes = new List<Type>();
            foreach(Type genericType in types)
            {
                if (IsIPlugin(genericType)) {
                    validTypes.Add(genericType);
                    Trace.WriteLine(Resources.PluginLoaderSuccesMessage + genericType.Name);
                }
                else
                {
                    throw new PluginLoaderException(Resources.PluginLoaderErrorMessage + genericType.FullName);
                }
            }
            return validTypes;
        }

        private static bool IsIPlugin(Type t)
        {
            return t.GetInterfaces().Contains(typeof(IPlugin));
        }
    }
}
