using System;
class Exercise14
{
    static void Main()
    {
        float celsius = 40;
        Console.WriteLine("Temperature in celsius is: " + celsius);
        float fahrenheit = ((celsius * 9) / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);
        Console.ReadKey();
    }
}
