using System;
using System.Linq;
using System.Reflection;

namespace ReflectionApp
{
    class SimpleSerializer
    {
        public static string Serialize(object obj)
        {
            string result = "";
            Type objType = obj.GetType();
            result += objType.Name + "\n";
            foreach(PropertyInfo pi in objType.GetProperties())
            {
                bool hasIgnoreAttribute = pi.GetCustomAttributes(typeof(SimpleSerializerIgnoreAttribute)).Any();
                if(hasIgnoreAttribute) { continue; }
                result += pi.Name + "\n" + pi.GetValue(obj).ToString() + "\n";
            }
            return result;
        }

        public static TData Deserialize<TData>(string txt)
        {
            Type targetType = typeof(TData);
            TData result = (TData)Activator.CreateInstance(targetType);

            string[] rows = txt.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i = 1; i < rows.Length; i += 2)
            {
                string name = rows[i];
                string value = rows[i + 1];

                PropertyInfo prop = targetType.GetProperty(name);
                object val = value;
                if(prop.PropertyType == typeof(int))
                {
                    val = int.Parse(value);
                }

                prop.SetValue(result, val);
            }

            return result;
        }
    }

    class SimpleSerializerIgnoreAttribute : Attribute
    {

    }

    class Person
    {
        [SimpleSerializerIgnore]
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string txt = SimpleSerializer.Serialize(new Person()
            {
                Age = 30,
                Name = "Franta"
            });
            Console.WriteLine(txt);
            Person x = SimpleSerializer.Deserialize<Person>(txt);


            //Loading dll using Assembly
            string path = @"D:\Coding\AT-.NET-GIT\cv02-Reflection\CalcLib\CalcLib\bin\Debug\netstandard2.0\CalcLib.dll";
            Assembly assembly = Assembly.LoadFile(path);

            //Creating instance of SimpleCalc using Activator
            Type calcType = assembly.GetType("CalcLib.SimpleCalc");
            object obj = Activator.CreateInstance(calcType);

            //Creating instance of SimpleCalc using Assembly
            //object obj2 = assembly.CreateInstance("CalcLib.SimpleCalc");

            //Calling public methods of SimpleCalc using Invoke 
            MethodInfo mi = calcType.GetMethod("SetXY");
            mi.Invoke(obj, new object[] { 10, 20 });
            mi = calcType.GetMethod("Add");
            mi.Invoke(obj, new object[] { });
            mi = calcType.GetMethod("ShowResult");
            mi.Invoke(obj, new object[] { });

            //Setting value of private field of SimpleCalc
            calcType.GetField("x", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(obj, 60);

            //Calling private methods of SimpleCalc using Invoke and BindingFlags
            mi = calcType.GetMethod("Multiply", BindingFlags.Instance | BindingFlags.NonPublic);
            mi.Invoke(obj, new object[] { });
            mi = calcType.GetMethod("ShowResult");
            mi.Invoke(obj, new object[] { });

            //Getting information about dll
            Type[] types = assembly.GetTypes();
            foreach(Type t in types)
            {
                Console.WriteLine(t.Name);

                foreach (FieldInfo f in t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
                {
                    Console.WriteLine(f.FieldType + " " + f.Name);
                }

                MethodInfo[] methods = t.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.DeclaredOnly);
                foreach(MethodInfo m in methods)
                {
                    string visibility = m.IsPublic ? "public" : m.IsPrivate ? "private" : "protected";
                    Console.Write(visibility);
                    Console.Write(" ");
                    Console.Write(m.ReturnType);
                    Console.Write(" ");
                    Console.Write(m.Name);
                    Console.Write("(");
                    foreach(ParameterInfo p in m.GetParameters())
                    {
                        Console.Write(p.ParameterType);
                        Console.Write(" ");
                        Console.Write(p.Name);
                        Console.Write(", ");
                    }
                    Console.Write(");");
                    Console.WriteLine();
                }
            }



        }
    }
}
