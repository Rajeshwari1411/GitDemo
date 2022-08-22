using System;

using System.Collections;


class Exercise8
{
     static public void Main()

    {
       Hashtable my_hashtable = new Hashtable();
       my_hashtable.Add("A1", "11");
       my_hashtable.Add("A2", "12");
       my_hashtable.Add("A3", "13");

         Console.WriteLine("Key and Value which are added :");
         
        foreach (DictionaryEntry ele1 in my_hashtable)

        {

            Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);

        }
        Console.WriteLine(" elements present" +

                 " in my_hashtable:{0}", "11,12,13");
        my_hashtable.Remove("A2");
        Console.WriteLine(" Elements present ater remove" +

                       " my_hashtable:{0}", "11,13");

    }
}
