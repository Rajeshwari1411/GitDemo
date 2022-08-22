using System;
using System.Collections.Generic;
public class Exercise10
{
    public static void Main(string[] args)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Hi");
        dict.Add(2, "Raji");
        dict.Add(3, "Welcome");
        Console.WriteLine("Values in Dictionary are: \n");
        foreach (KeyValuePair<int, string> item in dict)
        {
            Console.WriteLine(item.Key + "  " + item.Value);

        }
        Console.ReadKey();
    }
}