using System;
namespace Exercise
{
    class Program6
    {
        enum deptnames
        {
            Purchase=1,
            Sales=2,
            Training=3,
            Accounts=4,
        };
        static void Main(string[] args)
        {
            Console.WriteLine("The {0}st deptname is {1}", (int)deptnames.Purchase, deptnames.Purchase);
        }
    }
}
