using System;
using System.Collections;

public class Exercise11
{
    public static void Main(string[] args)
    {
        SortedList s = new SortedList();
        s.Add(75, "Hi");
        s.Add(26, "Raji");
        s.Add(18, "Welcome");
        foreach (DictionaryEntry item in s)
        {
            Console.WriteLine(item.Key + "  " + item.Value);
        }
    }
}
