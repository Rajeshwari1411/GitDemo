using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SEPT_12_HANDS_ON
{
    internal class Program
    {
        static void Main (string[]args)
        {
            string path = @"C:\Users\RAJESHWARI.R\source\repos\SEPT 12 HANDS ON\ClassLibrary1.A\bin\Debug\ClassLibrary 1.A.dll";
            Assembly asm = Assembly.LoadFrom(path);

            Type[] types = asm.GetTypes();
            foreach (var item in types)
            {


                Type t = asm.GetType(item.FullName);
                object obj = Activator.CreateInstance(t);


                item.InvokeMember("SqrRt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 4 });

                item.InvokeMember("Cube", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, new object[] { 4 });

                break;
            }
            Console.ReadLine();

            Console.WriteLine("================================================");
            Program.WritedataForEachCode(typeof(Song));
            Console.Read();
        }
        static void WritedataForEachCode(Type t)
        {
            Console.WriteLine("Methods " + t.Name);

            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is DeveloperAttribute)
                {
                    DeveloperAttribute a = (DeveloperAttribute)attr;
                    Console.WriteLine(a.SongName);

                }
            }
            Console.WriteLine("==========================================");
            MemberInfo[] minfo = t.GetMembers();

            foreach (var item in minfo)
            {
                System.Attribute[] attrs1 = System.Attribute.GetCustomAttributes(item);

                foreach (System.Attribute attrItem in attrs1)
                {
                    if (attrItem is DeveloperAttribute)
                    {
                        DeveloperAttribute B = (DeveloperAttribute)attrItem;
                        System.Console.WriteLine(B.SongName);
                        //System.Console.WriteLine(B.Language);
                        //System.Console.WriteLine(B.Lyrics);
                    }
                }

            }
        }



    }
    
}
