using System;
class EntryPoint
{
    static void Main()
    {
        //Finish this. 

        string tempUserName = "";
        string tempPassword = "";
        string userName = "";
        string password = "";

        bool realPasswordNumber = false;
        bool realPasswordCase = false;

        int passwordNumCount = 0;
        int passwordCaseCount = 0;

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

        Console.WriteLine();

        Console.WriteLine("Enter a password. It must be at least 8 characters, have at least one capital letter, one number:");
        tempPassword = Console.ReadLine();

        Console.WriteLine();

        if (tempPassword.Length >= 8)
        {

            for (int i = 0; i <= tempPassword.ToString()[tempPassword.ToString().Length]; i++)
            {
                if (tempPassword.ToString().Length - i >= 48 && tempPassword.ToString().Length - i <= 57)
                {
                    passwordNumCount++;
                }
                else
                {
                    passwordNumCount = passwordNumCount;
                }
            }

            for (int j = 0; j <= tempPassword.ToString()[tempPassword.ToString().Length]; j++)
            {
                if (tempPassword.ToString().Length - j >= 65 && (int)tempPassword.ToString().Length - j <= 90)
                {
                    passwordCaseCount++;
                }
                else
                {
                    passwordCaseCount = passwordCaseCount;
                }
            }
            if(passwordCaseCount >= 1) { realPasswordCase = true; } else { realPasswordCase = false; }
            if(passwordNumCount >= 1) { realPasswordNumber = true; } else { realPasswordNumber = false; }
            if (realPasswordNumber && realPasswordCase)
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

        //something here is wrong that I can't fix: 
        //Gotta figure out how to search through all the characters in order to find
        //a specific character within each one



        //bool realPasswordNumber = (int)tempPassword[tempPassword.Length - 1] >= 48 && (int)tempPassword[tempPassword.Length - 1] <= 57;
        //bool realPasswordCase = (int)tempPassword[tempPassword.Length - 1] >= 65 && (int)tempPassword[tempPassword.Length - 1] <= 90;

       
        Console.WriteLine("Your new Username is: " + userName);
        Console.WriteLine("Your new Password is: " + password);
        //The symbol code is a little difficult, so we'll hold onto it for now
        //bool realPasswordSymbol = (int)tempPassword[tempPassword.Length] 


    }
}

