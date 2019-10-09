using System;
class EntryPoint
{
    static void Main()
    {
        //Finish this. 
        /*
         * 
         * 
        int firstNumber = 4;
        int secondNumber = 5;


        if (secondNumber < firstNumber)
        {
        Console.WriteLine("4 is less than 5");
        }
        else
        {
        Console.WriteLine("4 is bigger than 5");
        }
        Console.WriteLine("I am after the IF statement");
         */


        string tempUserName = "";
        string tempPassword = "";
        string userName = "";
        string password = "";

        Console.WriteLine("Enter a username. It must be at least 3 characters:");
        tempUserName = Console.ReadLine();
        if(tempUserName.Length >= 3) 
        { 
            userName = tempUserName; 
        }
        else
        {
            userName = "defaultUser";
        }
        Console.WriteLine("Enter a password. It must be at least 8 characters, have at least one capital letter, one number:");
        tempPassword = Console.ReadLine();

        Console.WriteLine();

        //something here is wrong that I can't fix: 
        //Gotta figure out how to search through all the characters in order to find
        //a specific character within each one

        bool realPasswordNumber = false;
        bool realPasswordCase = false;

        for (int i = 0; i < tempPassword.ToString()[tempPassword.ToString().Length]; i++)
        {
            if((int)tempPassword[i] >= 48 && (int)tempPassword[i] <= 57)
        {
                 realPasswordNumber = true;
        }
            else
            {
                 realPasswordNumber = false;
            }
        }

        for (int j = 0; j < tempPassword.ToString()[tempPassword.ToString().Length]; j++)
        {
            if ((int)tempPassword[j] >= 65 && (int)tempPassword[j] <= 90)
            {
                realPasswordCase = true;
            }
            else
            {
                realPasswordCase = false;
            }
        }

        //bool realPasswordNumber = (int)tempPassword[tempPassword.Length - 1] >= 48 && (int)tempPassword[tempPassword.Length - 1] <= 57;
        //bool realPasswordCase = (int)tempPassword[tempPassword.Length - 1] >= 65 && (int)tempPassword[tempPassword.Length - 1] <= 90;

        if (tempPassword.Length >= 8)
        {
            if(realPasswordNumber && realPasswordCase)
            {
                password = tempPassword;
            }
            else if (!realPasswordCase)
            {
                password = "defaultpassword";
            }
            else if (!realPasswordNumber)
            {
                password = "defaultpassword";
            }
          
        }
        else if (tempPassword.Length < 8)
        {
            password = "defaultpassword";
        }
        Console.WriteLine("Your new Username is: " + userName);
        Console.WriteLine("Your new Password is: " + password);
        //The symbol code is a little difficult, so we'll hold onto it for now
        //bool realPasswordSymbol = (int)tempPassword[tempPassword.Length] 


    }
}

