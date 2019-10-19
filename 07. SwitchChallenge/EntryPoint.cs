using System;

class EntryPoint
{
    static void Main()
    {
        Console.Write("Press a number to select an option\n" +
            "1. Add New Item " +
            "\n2. Edit Item " +
            "\n3. Remove Item" +
            "\n4. Exit" +
            "\nYour Choice:");

        int choice = Convert.ToInt32(Console.ReadLine());
        switch(choice)
        {
            case 1:
                Console.WriteLine("An item has been added to the console.");
                break;
            case 2:
                Console.WriteLine("An item within the console is being edited.");
                break;
            case 3:
                Console.WriteLine("An item is being removed from the console.");
                break;
            case 4:
                Environment.Exit(0);//A complete exit from the system, even if it is
                break;
            default:
                Console.WriteLine("Yeah, pretty sure I gave you 4 numbers. \n" +
                    "1-4, but you're obviously trying to break my system. \n" +
                    "Thanks for trying though!");
                break;

        }
    }
}

