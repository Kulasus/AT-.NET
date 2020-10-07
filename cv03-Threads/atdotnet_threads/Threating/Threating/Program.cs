using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Threating
{
    

    class Program
    {
        private static async Task Experiment()
        {
            Console.WriteLine("Start");

            await Task.Delay(1000);

            using FileStream fs = new FileStream("test.txt", FileMode.Create);
            using StreamWriter sw = new StreamWriter(fs);
            await sw.WriteAsync("test");
            await sw.WriteAsync("pokus");

            await Task.Delay(1000);

            Console.WriteLine("End");
        }


        // Asynchronous application
        static async Task Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            await Experiment();
            Console.WriteLine("TEST");

            sw.Stop();
            Console.WriteLine("Čas v ms: " + sw.ElapsedTicks);


            // FOR FIRST AND SECOND TASK
            //MyStack myStack = new MyStack();


            /* SECOND TASK
            Random rand = new Random();

            object lockObject = new object();

            Thread t1 = new Thread(() =>
            {
                while (true)
                {
                    lock (lockObject)
                    {
                        myStack.Push(rand.Next());
                        Monitor.Pulse(lockObject); //Awakes other threads
                    }
                    Thread.Sleep(100);
                }
            });
            t1.Start();

            for (int i = 0; i < 5; i++)
            {
                Thread t = new Thread(() =>
                {
                    while (true)
                    {
                        lock (lockObject)
                        {
                            Console.WriteLine("Vlákno spuštěno: " + Thread.CurrentThread.ManagedThreadId);
                            while (myStack.PopIfNotEmpty(out int tmp))
                            {
                                Console.WriteLine($"Hodnota: {tmp} | Vlákno: {Thread.CurrentThread.ManagedThreadId}");
                            }
                            Monitor.Wait(lockObject); //Waits for awakening
                        }
                    }
                });
                t.Start();
            }
            
            t1.Join();
            */





            /* FIRST TASK
            List<Thread> threads = new List<Thread>();

            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {

                Thread t = new Thread(() =>
                {
                    if (rand.NextDouble() < 0.8)
                    {
                       if(myStack.PopIfNotEmpty(out int tmp))
                        {
                            Console.WriteLine(tmp);
                        }
                    }
                    else
                    {
                        myStack.Push(rand.Next());
                    }
                });
                threads.Add(t);
                t.Start();
            }

            foreach(Thread t in threads)
            {
                t.Join();
            }
            */
        }
    }
}
