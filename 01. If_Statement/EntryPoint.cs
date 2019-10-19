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

        Console.WriteLine("Enter a password. It must be at least 8 characters, \n" +
            "have at least one capital letter and one number:");
        tempPassword = Console.ReadLine();

        Console.WriteLine();

        if (tempPassword.Length >= 8)
        {

            for (int i = 0; i <= tempPassword.ToString().Length - 1; i++)
            {
                if (tempPassword[i] >= 48 && tempPassword[i] <= 57)
                {
                    passwordNumCount++;
                }
                else
                {
                    passwordNumCount = passwordNumCount;
                }
            }

            for (int j = 0; j <= tempPassword.ToString().Length - 1; j++)
            {
                if (tempPassword[j] >= 65 && (int)tempPassword[j] <= 90)
                {
                    passwordCaseCount++;
                }
                else
                {
                    passwordCaseCount = passwordCaseCount;
                }
            }
            
            if (passwordNumCount >= 1 && passwordCaseCount >= 1)
            {
                password = tempPassword;
            }
            else if (passwordNumCount < 1 || passwordCaseCount < 1)
            {
                password = "defaultpassword";
            }

        }
        else if (tempPassword.Length < 7)
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

