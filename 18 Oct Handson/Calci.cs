using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class Calci
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public double Sqrt(int i)
        {
            return Math.Sqrt(i);
        }
        public bool Login(string uid, string pwd)
        {

            if (pwd == "Test@123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

