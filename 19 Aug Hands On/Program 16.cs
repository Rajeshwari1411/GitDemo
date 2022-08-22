using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program16
    {
        static void Main(string[] args)
        {
            int i;
            string str = " ";
            int sum = 100;
            for (i = 0; i < 4; i++)
            {
                str = Console.ReadLine();
                if (str.Equals("HIT"))
                {
                    sum += 10;
                }
                else if (str.Equals("MISS"))
                {
                    sum -= 20;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}