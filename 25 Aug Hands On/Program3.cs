using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _25_aug_pro1
{
    internal class Program3
    {
        public static void Main()
        {
             /*Directory.CreateDirectory("C:\\Results");
             Console.WriteLine("Created");

             DirectoryInfo dir = new DirectoryInfo(@"C:\\Results");
             dir.CreateSubdirectory("Results17-18");
             dir.CreateSubdirectory("Results18-19");
            dir.CreateSubdirectory("Results20-21");
            Console.WriteLine("created");
            Console.ReadLine();

             string path = @"C:\Results\Results17-18\";
             Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();

             File.Create(path+fname);
            Console.WriteLine("file created successfully...");


             string path = @"C:\Results\Results18-19\";
             Console.WriteLine("Enter the file name");
            string fname = Console.ReadLine();

             File.Create(path + fname);
            Console.WriteLine("file created successfully...");


             string path = @"C:\Results\Results20-21\";
            Console.WriteLine("Enter the file name");
             string fname = Console.ReadLine();

            File.Create(path + fname);
            Console.WriteLine("file created successfully...");*/

            string fname = @"C:\\Results";
            
            var dirs = from dir in
                Directory.EnumerateDirectories(fname)
                       select dir;
            Console.WriteLine("Subdirectories: {0}", dirs.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in dirs)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }
  
            var ResultsDirs = from dir in
                Directory.EnumerateDirectories(fname, "Results*")
                         select dir;
            Console.WriteLine("Subdirectories: {0}", ResultsDirs.Count<string>().ToString());
            Console.WriteLine("List of Subdirectories");
            foreach (var dir in ResultsDirs)
            {
                Console.WriteLine("{0}", dir.Substring(dir.LastIndexOf("\\") + 1));
            }









        }
    }
}
 