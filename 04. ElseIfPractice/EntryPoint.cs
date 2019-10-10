using System;

class EntryPoint
{
    static void Main()
    {
        //Write an expression to see if a given point (x,y)
        //Is within a circle with a radius of 4 and center at (0,0)

        Console.WriteLine("Are you within the circle? \n" +
            "It has a radius of 4 and its center is 0,0. \n" +
            "Enter your x and y axes.");

        Console.Write("X: ");
        double xAxis = Convert.ToInt32(Console.ReadLine());
        Console.Write("Y: ");
        double yAxis = Convert.ToInt32(Console.ReadLine());

        double radius = 4;
        double distance = Math.Sqrt(Math.Pow(xAxis, 2) + Math.Pow(yAxis, 2));
                     
        if(distance == radius)
        {
            Console.WriteLine($"The distance {distance} is exactly on the point of the circle!");
        }
        else if(distance < radius)
        {
            Console.WriteLine($"The distance {distance} is smaller than the radius. \n" +
                $"So it is inside the circle");
        }
        else if (distance > radius)
        {
            Console.WriteLine($"The distance {distance} is larger than the radius \n" +
                $"So it is outside the circle");
        }

        //Take an input in meters, converts the meters into another unit
        //Ask the what kind of conversion they want: mm, cm, m, km, or micrometers

        Console.WriteLine();
        Console.WriteLine("Next trick, we are doing meter conversion!");
        Console.WriteLine("First give me a meter amount.");
        double meters = Convert.ToInt32(Console.ReadLine());
        double conversionAmount = 0.0f;
        Console.WriteLine("Now give me a conversion. \n" +
            "Use cm, mm, km, dm, or ft. \n" +
            "Make sure to use the two digits or it won't work.");
        string conversionChoice = Console.ReadLine();
        if(conversionChoice.Length !=2)
        {
            Console.WriteLine("Pretty sure that's the wrong symbol");
        }
        else if(conversionChoice.Length == 2 && conversionChoice == "cm")
        {
            conversionAmount = meters / 100;
        }
        else if(conversionChoice.Length == 2 && conversionChoice == "mm")
        {
            conversionAmount = meters / 1000;
        }
        else if (conversionChoice.Length == 2 && conversionChoice == "km")
        {
            conversionAmount = meters * 1000;
        }
        else if (conversionChoice.Length == 2 && conversionChoice == "dm")
        {
            conversionAmount = meters / 10;
        }
        else if (conversionChoice.Length == 2 && conversionChoice == "ft")
        {
            conversionAmount = meters * 3.2808399;
        }
        if (conversionChoice.Length == 2)
        {
            Console.WriteLine($"And like magic, your {meters} meters is now {conversionAmount} in {conversionChoice}");
        }
        else if(conversionChoice.Length != 2)
        {
            return;
        }



    }
}

