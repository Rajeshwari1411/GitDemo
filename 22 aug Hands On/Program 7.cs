using System;
using System.Collections;
namespace Exercise7
{
    class Example
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            
            Console.Write("Original queue: ");
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }
            q.Dequeue();
            q.Dequeue();
            Console.WriteLine();
            Console.Write("Queue after Dequeue() operation: ");
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }
            foreach (int i in q)
             {
                Console.Write(i + " ");
             }
                Console.WriteLine();
                Console.Write("peek element is: {0}", q.Peek());
            
        }
    }
}
    

