﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReuseCode
{
    public class Program5
    {
        public static void Uppercase()
        {
            //Program 5
            Console.WriteLine("Enter a String: ");
            string s = Console.ReadLine();
            string s1 = s.ToUpper();
            Console.WriteLine("Converted String: " + s1);
        }
    }
}
