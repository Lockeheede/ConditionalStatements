using System;
class EntryPoint
{
    static void Main()
    {
        //The switch statement gives you a value, a case to test against it, 
        //a break statement for when a case is met, and a default case in 
        //case there are no matching cases.
        //Switch is what you are looking for
        Console.Write("Time to convert from meters to something new!\n" +
            "First, how many meters would you like to convert?\n");
        double meterAmount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Alright, now what would you like to convert to?\n" +
            "You can use um, mm, cm, dm, km or ft!\n");


        string meterConverter = Console.ReadLine();

        switch (meterConverter)
        {
            //case is what you test against the switch
            case "um":
                meterAmount = meterAmount * 1000000;
                Console.WriteLine($"Micrometers! Ok this will equal {meterAmount} {meterConverter}");
                //break is needed at the end of each case, except when using multiple cases
                break;

            case "mm":
                meterAmount = meterAmount * 1000;
                Console.WriteLine($"Millimeters! Ok this will equal {meterAmount} {meterConverter}");
                break;
            //when you meet the correct case (basically when case == switch) then you break,
            //skip the rest of the cases and do the condition that is in the proper case.
            case "cm":
                meterAmount = meterAmount * 100;
                Console.WriteLine($"Centimeters! Ok this will equal {meterAmount} {meterConverter}");
                break;
            case "dm":
                meterAmount = meterAmount * 10;
                Console.WriteLine($"Decameters! Ok this will equal {meterAmount} {meterConverter}");
                break;
            case "km":
                meterAmount = meterAmount / 1000;
                Console.WriteLine($"Kilometers! Ok this will equal {meterAmount} { meterConverter}");
                break;
            case "ft":
                meterAmount = meterAmount * 3.2808399;
                Console.WriteLine($"Feet! Ok this will equal {meterAmount} {meterConverter}");
                break;
            default:
                Console.WriteLine($"You entered {meterConverter}, but it doesn't match any of the options I gave you. Game over I guess...");
                break;
        }
        Console.WriteLine("This is an estimate! The computers can only handle so many numbers!");
        Console.WriteLine("The end.");
        Console.WriteLine();
    }
}

