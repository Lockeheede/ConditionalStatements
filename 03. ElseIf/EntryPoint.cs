using System;
class EntryPoint
{
    static void Main()
    {
        //100 enemies; 1 player; Press S to slash, killing 1 enemy; Press M for magic, killing 10 enemies
        int enemyCount = 100;
        Console.WriteLine("Enter your player name!");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Welcome to the game {playerName}! You must protect the village!");
        int score = 0;
        int bonusScore = 0;
        int totalScore = 0;
        Console.WriteLine($"Kill {enemyCount} enemies in order to win! ");
        Console.WriteLine("Press S to slash, and press M for magic!");
        Console.WriteLine("A slash gives you 100 points and kills 1 enemy, \n" +
            "and magic gives you 20 points and kills 10 enemies! \n" +
            "If you kill all the enemies you get a bonus of 20% added to your score!");
        Console.WriteLine("BEGIN!!! Press escape to quit the game...");

        //Try to come up with a way to show the game is over with the expected message after pressing escape and having a certain amount of enemies available
        //Also post the score after quitting without getting all the enemies killed
        //Also figure out a time method

        do
        {
            if (enemyCount >= 75 && enemyCount <= 80 && Console.ReadKey().Key == ConsoleKey.Escape)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You quit? Well the remaining {enemyCount} enemies killed everyone and they are eatting faces...");
            Console.ResetColor();
            }
            else if (enemyCount >= 50 && enemyCount <= 74 && Console.ReadKey().Key == ConsoleKey.Escape)
            {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"You quit? Well the remaining {enemyCount} enemies killed everyone...");
            Console.ResetColor();
            }
            else if (enemyCount <= 49 && enemyCount >= 0 && Console.ReadKey().Key == ConsoleKey.Escape)
            {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"You quit? Well you almost killed all the enemies. \n" +
                $"There were only {enemyCount} left! They only maimed everyone. \n" +
                $"So I guess that's okay...");
            Console.ResetColor();
            }
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                Console.WriteLine("That's a slash!");
                enemyCount -= 1; score += 100;
                Console.WriteLine($"Your score is {score}");
            }
            else if (Console.ReadKey().Key == ConsoleKey.M)
            {
                Console.WriteLine("That's a magic blast!");
                enemyCount -= 10; score += 20;
                Console.WriteLine($"Your score is {score}");
            }
            if (enemyCount <= 0)
            {
                bonusScore = (int)(score * 0.2);
                totalScore = bonusScore + score;
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"Good job {playerName} you killed all the enemies! \n" +
                    $"You received {score} with a bonus score of {bonusScore}. \n" +
                    $"You have {totalScore} points!");
                Console.ResetColor();
            }
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}

