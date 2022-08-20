using System;
namespace Exercise5
{
    class Test
    {
        static void Main(string[] args)
        {
            int num1=10;
            int num2=20;
            int maxNum;
            Console.WriteLine("Number 1: " + num1);
            Console.WriteLine("Number 2: " + num2);
            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            Console.WriteLine("Maximum number is: " + maxNum);
            Console.ReadKey();
        }
    }
}