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

namespace ATNET_DESKTOP_KON0355_STOCKMETALPRICES.Helpers
{
    public static class PluginLoader
    {

        public static void LoadPlugins()
        {
            Debug.WriteLine("LOADING PLUGINS");
            string path = Application.StartupPath + "\\Plugins";
            Debug.WriteLine(path);
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");
            foreach(string s in pluginFiles)
            {
                Assembly assembly = Assembly.LoadFile(s);
                Type[] types = assembly.GetTypes();
                foreach(Type t in types)
                {
                    if (IsIPlugin(t))
                    {
                        object obj = Activator.CreateInstance(t);
                        MethodInfo method = t.GetMethod("Greet");
                        method.Invoke(obj, new object[] { });
                    }
                }
            }
        }

        private static bool IsIPlugin(Type t)
        {
            return t.GetInterfaces().Contains(typeof(IPlugin));
        }
    }
}
