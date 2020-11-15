using System;
using System.IO;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.Helpers
{
    /// <summary>
    /// Helper class to utilize settingsPath location use
    /// </summary>
    static class Session
    {
        public static readonly string projectPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\"));
        public static readonly string settingsPath = projectPath+@"\Resources\settings.xml";
    }
}
