using System;
public class Exercise16
{
    public static void Main()
    {
        string username, password;

        Console.Write("\n\nCheck username and password :\n");
        Console.Write("N.B. : Default user name and password is :abcd and 1234\n");
        Console.Write("------------------------------------------------------\n");



        Console.Write("Input a username: ");
        username = Console.ReadLine();

        Console.Write("Input a password: ");
        password = Console.ReadLine();

        if (username != "abcd" || password != "1234")
            Console.Write("\nsuccessfully logged in!\n\n");
        else 
            Console.Write("\nnot logged in!\n\n");
       
    }
}

        
       
    

