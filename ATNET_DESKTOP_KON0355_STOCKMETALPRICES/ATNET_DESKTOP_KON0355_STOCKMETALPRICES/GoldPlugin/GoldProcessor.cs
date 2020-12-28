using System.Diagnostics;
using SharedContext;

namespace GoldPlugin
{
    public class GoldProcessor : IPlugin
    {
        public void Greet()
        {
            Debug.WriteLine("Hello from GoldProcessor!");
        }
    }
}
