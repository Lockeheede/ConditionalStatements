using System;
class EntryPoint
{
    static void Main()
    {
        string userName = string.Empty;
        string password = string.Empty;

        Console.Write("Enter your username: ");
        userName = Console.ReadLine();

        if (userName == "admin")
        {
            Console.Write("Welcome, admin! Please enter your password: ");
            password = Console.ReadLine();
        }
    }
}

