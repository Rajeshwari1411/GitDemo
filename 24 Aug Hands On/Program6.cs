using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ReuseCode
{
    public class Program6
    {
        public static void Makefile()
        {
            //Program 6
            string path = @"C:\Users\RAJESHWARI.R\source\repos\Rajii.txt";
            File.Create(path);
        }
    }
}
