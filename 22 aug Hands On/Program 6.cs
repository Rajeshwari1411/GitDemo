using System;
using System.Collections.Generic;
namespace Exercise
{
    internal class Program6
    {

        static void Main(string[] args)
        {

            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(205);
            st.Push(300);
            st.Push(400);
            st.Push(500);
            Console.WriteLine($"No.of.elements in stack:" + st.Count);
            Console.WriteLine("STACK ELEMENTS");

            st.Push(500);
            foreach (var item in st)
            {
                Console.WriteLine(item + "\t");
            }
            Console.WriteLine($"top element:" + st.Peek());
            st.Pop();
            st.Pop();
            Console.WriteLine($"top element:" + st.Peek());
            Console.ReadLine();
        }
    }
}

