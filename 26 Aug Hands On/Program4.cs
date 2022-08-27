using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_aug_q4
{
    internal class Program4
    {
        static void Main(string[] args)
        {
            LinkedList<string> mylist = new LinkedList<string>();
            mylist.AddFirst("Raj");
            mylist.AddLast("Mini");
            mylist.AddAfter(mylist.First, "Selva");
            mylist.AddBefore(mylist.Last, "Jaya");
            mylist.AddBefore(mylist.Last.Previous, "Venkat");
            mylist.AddAfter(mylist.First.Next, "Mani");
            LinkedListNode<string> foundnode = mylist.Find("Raj");
            foundnode.Value = "Gayu";

            foreach (var item in mylist)
            {
                Console.WriteLine(item);

            }
            Console.ReadKey();
        }
    }
}
