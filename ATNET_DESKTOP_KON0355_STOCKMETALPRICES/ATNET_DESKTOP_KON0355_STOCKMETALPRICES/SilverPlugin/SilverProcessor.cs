using System.Diagnostics;
using SharedContext;

namespace SilverPlugin
{
    class SilverProcessor : IPlugin
    {
        public void Greet()
        {
            Debug.WriteLine("Hello from SilverProcessor!");
        }
    }
}
