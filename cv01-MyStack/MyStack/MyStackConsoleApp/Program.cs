using System;
using System.IO;
using MyStack;

namespace MyStackConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStringStack();
            TestDoubleStack();
        }

        private static void Save(MyStack<double> stack)
        {
            using (FileStream fs = new FileStream("data.txt", FileMode.Create)) { 
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach(double item in stack)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            } 
        }

        private static MyStack<double> Load()
        {
            MyStack<double> stack = new MyStack<double>(10);
            using(FileStream fs = new FileStream("data.txt", FileMode.Open)){
                using(StreamReader sr = new StreamReader(fs))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) { continue; }
                        double val = double.Parse(line);
                        stack.Push(val);
                         
                    }
                }
            }
            return stack;
        }

        private static void TestStringStack()
        {
            Console.WriteLine("String stack: ");

            MyStack<string> myStackString = new MyStack<string>(10);

            myStackString.Push("Value 1");
            myStackString.Push("Value 2");
            myStackString.Push("Value 3");
            myStackString.Push("Value 4");

            Console.WriteLine(myStackString.top);

            myStackString.Pop();
            myStackString.Pop();

            Console.WriteLine(myStackString.top);

            myStackString.Push("Value 5");

            Console.WriteLine(myStackString.top);

            Console.WriteLine("Enumerating over stack: ");
            foreach(String item in myStackString)
            {
                Console.WriteLine(item);
            }
        }

        private static void TestDoubleStack()
        {
            Console.WriteLine("Double stack: ");

            MyStack<double> myStackDouble = new MyStack<double>(10);

            myStackDouble.Push(1.0);
            myStackDouble.Push(2.0);
            myStackDouble.Push(3.0);
            myStackDouble.Push(4.0);

            Console.WriteLine(myStackDouble.top);

            myStackDouble.Pop();
            myStackDouble.Pop();

            Console.WriteLine(myStackDouble.top);

            myStackDouble.Push(5.0);

            Console.WriteLine(myStackDouble.top);

            Console.WriteLine("Enumerating over stack: ");
            foreach (double item in myStackDouble)
            {
                Console.WriteLine(item);
            }


            // Testing save and load to and from file
            Save(myStackDouble);
            MyStack<double> myStackDoubleLoaded = Load();
            foreach (double item in myStackDoubleLoaded)
            {
                Console.WriteLine(item);
            }
        }
    }
}
