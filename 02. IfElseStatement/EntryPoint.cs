using System;
class EntryPoint
{
    static void Main()
    {

        //Read the WriteLine codes to see what this code is trying to perform

        int givenNum = 0;
        Console.Write("Give me a number. I will see if it is odd or even: ");
        //Remember to use the Convert.ToInt32 to read what the user types and convert it into an integer
        givenNum = Convert.ToInt32(Console.ReadLine());
        int modulousNum = givenNum % 2;

        if(modulousNum == 0)
        {
            Console.WriteLine(givenNum + " is an even number.");
        }
        else if(modulousNum == 1)
        {
            Console.WriteLine(givenNum + " is an odd number.");
        }

        Console.WriteLine();

        int givenNum1 = 0;
        Console.Write("Give me another number, I will see if I can divide it\n" +
            "by 2, 3, or 4: ");
        givenNum1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        int byTwo = givenNum1 % 2;
        if (byTwo == 0) { Console.WriteLine(givenNum1 + " can be divided by two."); }
        else if (byTwo != 0) { Console.WriteLine(givenNum1 + " cannot be divided by two."); }

        int byThree = givenNum1 % 3;
        if (byThree == 0) { Console.WriteLine(givenNum1 + " can be divided by three."); }
        else if (byThree != 0) { Console.WriteLine(givenNum1 + " cannot be divided by three."); }

        int byFour = givenNum1 % 4;
        if (byFour == 0) { Console.WriteLine(givenNum1 + " can be divided by four."); }
        else if (byFour != 0) { Console.WriteLine(givenNum1 + " cannot be divided by four."); }

        Console.WriteLine();

        Console.Write("Another number please, I'll try to see\n" +
            "if I can divide it " +
            "by 2, 3, or 4, all at once: ");
        int givenNum2 = Convert.ToInt32(Console.ReadLine());
        if (givenNum2 % 2 == 0 && givenNum2 % 3 == 0 && givenNum2 % 4 == 0)
        {
            Console.WriteLine($"The number, {givenNum2} is divisible by 2,3, and 4");
        }
        else
        {
            Console.WriteLine($"I'm sorry, but {givenNum2} cannot be divided by all 3 numbers");
        }


        Console.WriteLine();

        //write an expression that will check if the 3rd digit of an int is 3
        //To do this you have to convert to a string
        //This is probably what you were trying to figure in the if statement project
        Console.Write("Give me a number, I will check\n" +
            "if it has a 3 as the 3rd number: ");
        int givenNum3 = Convert.ToInt32(Console.ReadLine());

        if(givenNum3.ToString()[givenNum3.ToString().Length - 3] == '3')
        {
            Console.WriteLine($"Yes, the number {givenNum3} does have a 3 for the 3rd number!");
        }
        else
        {
            Console.WriteLine($"No, the number {givenNum3} does not have a 3 as the 3rd number!" );
        }
        Console.WriteLine();
    }
}

