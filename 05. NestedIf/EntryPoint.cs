using System;
class Program
{
    static void Main()
    {
        /*
        string userName = string.Empty;//string.Empty is the same as " ". An empty string
        string password = string.Empty;

        Console.Write("Input your username: ");
        userName = Console.ReadLine();

        if(userName == "admin")
        {
            Console.Write("Welcome admin. Please enter your password: ");
            password = Console.ReadLine();

            if (password == "password")
            {
                Console.WriteLine("Welcome admin! Full access has been granted to you!");
            }
        }
        */

        //Challenge. Take three integers and then sort them from smallest to largest using Nested Loops. 
        int firstInt = 0;
        int secondInt = 0;
        int thirdInt = 0;

        Console.WriteLine("Ordering system. Give me three integers and I will put them in order from smallest to largest.");
        Console.Write("First Integer: ");
        firstInt = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second Integer: ");
        secondInt = Convert.ToInt32(Console.ReadLine());
        Console.Write("Third Integer: ");
        thirdInt = Convert.ToInt32(Console.ReadLine());

        //This is going to need work in order for the inital statement (the first if) to register each integer. Having it all be based on the firstInt is why
        //I am having this issue. It only tests if the first int is larger or smaller but not if the second or third are larger or smaller
        //I would need to code more to register the data of the third or second Ints incase the first is not bigger than the second, third or smaller than the 
        //second. The nested loops only work if the inital if is true, so each type of possiblity needs to be input. 
        if (firstInt > secondInt)
        {
            if (firstInt > thirdInt)
            {
                if (secondInt > thirdInt)
                {
                    Console.WriteLine($"Smallest: {thirdInt}, middle: {secondInt}, largest: {firstInt}");
                }
                else if (secondInt < thirdInt)
                {
                    Console.WriteLine($"Smallest: {secondInt}, middle: {thirdInt}, largest: {firstInt}");
                }
            }

            else if (firstInt < thirdInt)
            {
                if (secondInt < thirdInt)
                {
                    if (secondInt < firstInt)
                    {
                        Console.WriteLine($"Smallest: {secondInt}, middle: {firstInt}, largest: {thirdInt}");
                    }
                    else if (secondInt > firstInt)
                    {
                        Console.WriteLine($"Smallest: {firstInt}, middle: {secondInt}, largest: {thirdInt}");
                    }
                }
            }
            else if (firstInt < secondInt)
            {
                if (secondInt > thirdInt)
                {
                    if (firstInt > thirdInt)
                    {
                        Console.WriteLine($"Smallest: {thirdInt}, middle: {firstInt}, largest: {secondInt}");
                    }
                    else if (firstInt < thirdInt)
                    {
                        Console.WriteLine($"Smallest: {firstInt}, middle: {thirdInt}, largest: {secondInt}");
                    }
                }
                Console.WriteLine($"Smallest: {secondInt}, middle: {firstInt}, largest: {thirdInt}");
            }
        }
      
        
    }
}

