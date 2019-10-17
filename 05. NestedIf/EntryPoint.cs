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
       





   

        //This is going to need work in order for the inital statement (the first if) to register each integer. Having it all be based on the firstInt is why
        //I am having this issue. It only tests if the first int is larger or smaller but not if the second or third are larger or smaller
        //I would need to code more to register the data of the third or second Ints incase the first is not bigger than the second, third or smaller than the 
        //second. The nested loops only work if the inital if is true, so each type of possiblity needs to be input. 

        /* Keep the information below to remember how stupid of an approach this was...
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

            else if (secondInt > firstInt)
            {
                if (secondInt > thirdInt)
                {
                    if (thirdInt > firstInt)
                    {
                        Console.WriteLine($"Smallest: {firstInt}, middle: {thirdInt}, largest: {secondInt}");
                    }
                    else if (thirdInt < firstInt)
                    {
                        Console.WriteLine($"Smallest: {thirdInt}, middle: {firstInt}, largest: {secondInt}");
                    }
                }
            }

            else if (thirdInt > secondInt)
            {
                if (secondInt > firstInt)
                {
                    if (thirdInt > firstInt)
                    {
                        Console.WriteLine($"Smallest: {firstInt}, middle: {secondInt}, largest: {thirdInt}");
                    }
                    else if (thirdInt < firstInt)
                    {
                        Console.WriteLine($"Smallest: {thirdInt}, middle: {firstInt}, largest: {secondInt}");
                    }
                }
            }

            else if (thirdInt > firstInt)
            {
                if (thirdInt > secondInt)
                {
                    if (firstInt > secondInt)
                    {
                        Console.WriteLine($"Smallest: {secondInt}, middle: {firstInt}, largest: {thirdInt}");
                    }
                    else if (firstInt < secondInt)
                    {
                        Console.WriteLine($"Smallest: {firstInt}, middle: {secondInt}, largest: {thirdInt}");
                    }
                }
            }
            */

        //A more simplified approach to this situation which was also kind of stupid
        int a = 0; int b = 0; int c = 0;
        string sorted = string.Empty;


        Console.WriteLine("Ordering system. Give me three integers and I will put them in order from smallest to largest.");
        Console.Write("First Integer: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Second Integer: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Third Integer: ");
        c = Convert.ToInt32(Console.ReadLine());


        //In this case you are using multiple booleans and nested ifs. You are also using concatenation to add to the empty sorted string
        if (a > b && a > c)
        {
            sorted = a + " ";
            if (b > c)
                sorted = sorted + b + " " + c;
            else
                sorted = sorted + c + " " + b;
        }
        else if (b > a && b > c)
        {
            sorted = b + " ";
            if (a > c)
                sorted = sorted + a + " " + c;
            else
                sorted = sorted + c + " " + a;
        }
        else if (c > a && c > b)
        {
            sorted = c + " ";
            if (a > b)
                sorted = sorted + a + " " + b;
            else
                sorted = sorted + b + " " + a;
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("At least one of these numbers are equal, so I can't sort them!");
            return; 
        }
        Console.WriteLine(sorted);
        
        }
      
        
    }


