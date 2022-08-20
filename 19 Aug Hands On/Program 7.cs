using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Exercise7
{
    static void Main(string[] args)
    {
        double rl, phy, che, math, total;
        double per;
        string nm, div;






        Console.Write("Input  the marks of Physics : ");
        phy = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of  Chemistry : ");
        che = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input  the marks of Math : ");
        math = Convert.ToInt32(Console.ReadLine());

        total = phy + che + math;
        per = total / 3.0;
        if (per >= 60)
            div = "First";
        else
            if (per < 60 && per >= 45)
            div = "Second";
        else
                if (per < 45 && per >= 35)
            div = "Third";
        else
            div = "Fail";


        Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Math : {2}\n", phy, che, math);
        Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);

        Console.ReadLine();
    }
}
