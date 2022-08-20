using System;
public class Exercise1
{
    public static void Main(string[]args)
    {
        int num1, num2, temp;
        Console.Write("\nInput the First num : ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("\nInput the Second num : ");
        num2 = int.Parse(Console.ReadLine());
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst num : " + num1);
        Console.Write("\nSecond num : " + num2);
        Console.Read();

    }
}
   


