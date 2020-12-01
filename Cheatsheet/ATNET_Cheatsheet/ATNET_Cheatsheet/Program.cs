using System;
using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace ATNET_Cheatsheet
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------APP DOMAIN - Jen pro .NET Framework-----------------------
            /*
            AppDomain domain = AppDomain.CreateDomain("MyDomain");
            Console.WriteLine("Host domain: " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Child domain: " + domain.FriendlyName);

            AppDomain.Unload(domain);
            try
            {
                Console.WriteLine("child domain: " + domain.FriendlyName);
            }
            catch(AppDomainUnloadedException e)
            {
                Console.WriteLine("The appdomain MyDomain does not exsit");
            }

            PermissionSet ps = new PermissionSet(PermissionState.None);
            ps.AddPermission(new SecurityPermision(SecurityPermissionFlag.Execution));
            */

            //------------------------------------ASSEMBLY---------------------------------------------
            //Assembly properties
            /*
            Assembly executing = Assembly.GetExecutingAssembly();
            Console.WriteLine(executing.EntryPoint);
            Console.WriteLine(executing.FullName);
            Console.WriteLine(executing.GlobalAssemblyCache);
            Console.WriteLine(executing.Location);
            Console.WriteLine(executing.ReflectionOnly);
            //Void Main(System.String[]);
            //Test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
            //False
            //Location...
            //False
            */
            //Assembly methods
            /*
            Assembly executing = Assembly.GetExecutingAssembly();
            foreach(Module module in executing.GetModules())
            {
                Console.WriteLine(module.Name);
            }
            foreach(Type type in executing.GetTypes())
            {
                Console.WriteLine(type);
            }*/

            //-------------------------------------REFLECTION-------------------------------------------
            /*
            Type type = typeof(string);
            foreach(MemberInfo memberInfo in type.GetMembers())
            {
                if(memberInfo.MemberType == MemberTypes.Property)
                {
                    Console.WriteLine(memberInfo.Name);
                }
            }
            MethodInfo method = type.GetMethod("Equals");
            MethodBody body = method.GetMethodBody();
            foreach (LocalVariableInfo localVariable in body.LocalVariables)
            {
                Console.WriteLine(localVariable.LocalType);
            }
            */
            //-*-*-*-*-*-New class instance 
            /*
            object person = Activator.CreateInstance(typeof(Person));
            //nebo
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            object person = myAssembly.CreateInstance("Namespace.ClassName");
            */
            //s parametry
            /*
            object[] parameters = new object[] { 28, "Jan" };
            object person = Activator.CreateInstance(typeof(Person), parameters));
            */
            /*
            Type t = typeof(MyClass);
            MemberInfo[] members = t.GetMembers();
            for(int i = 0; i < members.Length; i++)
            {
                Object[] attrs = members[i].GetCustomAttributes(true);
                for(int j = 0; j < attrs.Length; j++)
                {
                    Console.WriteLine("attribute is {0}.", attrs[j]);
                    Console.WriteLine(((MyAttribute)attrs[j]).Name);
                }
            }
            */

            //----------------------------------------THREADS--------------------------------------

        }
    }
}
