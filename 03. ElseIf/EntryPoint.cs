using System;
class EntryPoint
{
    static void Main()
    {
        //100 enemies; 1 player; Press S to slash, killing 1 enemy; Press M for magic, killing 10 enemies
        int enemyCount = 100;
        Console.WriteLine("Enter your player name!");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Welcome to the game {playerName}! You must kill the enemies!");
        int score = 0;
        Console.WriteLine($"Kill {enemyCount} enemies in order to win! ");
        Console.WriteLine("Press S to slash, and press M for magic!");
        Console.WriteLine("A slash gives you 10 points and kills 1 enemy, " +
            "and magic gives you 5 points and kills 10 enemies!");
        Console.WriteLine("Press escape to quit the game...");
        do
        {
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                Console.WriteLine("That's a slash!");
                enemyCount -= 1; score += 10;
                Console.WriteLine($"Your score is {score}");
            }
            else if (Console.ReadKey().Key == ConsoleKey.M)
            {
                Console.WriteLine("That's a magic blast!");
                enemyCount -= 10; score += 5;
                Console.WriteLine($"Your score is {score}");
            }
            if (enemyCount <= 0)
            {
                Console.WriteLine($"Good job {playerName} you killed all the enemies! Your score is {score}!");
            }
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

