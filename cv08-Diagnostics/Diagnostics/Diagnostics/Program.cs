using System;
using System.Diagnostics;

namespace Diagnostics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int x = rand.Next();
            Debugger.Launch();
            /*
            //Přidání vlastního Listeneru
            Trace.Listeners.Add(new MyFileListener());
            Trace.Listeners.Add(new ConsoleTraceListener());

            string text = Console.ReadLine();
            Debug.WriteLineIf(text.Length > 5, "Zadán text delší než 5");
            Debug.WriteLine("Aplikace byla spuštěna.");

            //Jde vidět i v release režimu
            Trace.WriteLine("Aplikace byla spuštěna 2.");

            Trace.Flush();
            */
        }
    }
}
