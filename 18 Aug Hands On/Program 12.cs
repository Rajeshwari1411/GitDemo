using System;
class Exercise12
{

    
    public static void Main(string[] args)
    {
        string s1 = "";

        // or declare String s2.Empty;
        string s2 = "";

        string s3 = null;

        // for String value Geeks, return true
        bool b1 = string.IsNullOrEmpty(s1);

        // For String value Empty or "", return true
        bool b2 = string.IsNullOrEmpty(s2);

        // For String value null, return true
        bool b3 = string.IsNullOrEmpty(s3);

        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
    }
}
