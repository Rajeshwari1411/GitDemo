using System;
using System.Collections.Generic;

public class Exercise10
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nInput first integer:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input second integer:");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
    }
}