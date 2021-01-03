using System.Collections.Generic;

namespace SharedContext
{
    public interface IPlugin
    {
          Dictionary<string,string> GetJsonDataDict();
    }
}
