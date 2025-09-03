using System;

public enum Choice { Rock, Paper, Scissors };

public class Player
{
    public int Score { get; set; } = 0;
    public Choice Choice { get; set; }
}

public static class Game
{
    private static Random rand = new Random();

    public static void GetUserChoice(Player player)
    {
        while (true)
        {
            Console.Write("Choose Rock, Paper, or Scissors: ");
            if (Enum.TryParse(Console.ReadLine(), true, out Choice parsedChoice))
            {
                player.Choice = parsedChoice;
                break;
            }
            Console.WriteLine("Invalid choice. Try again.");
        }
    }

    public static void ComputerChoice(Player computer)
    {
        computer.Choice = (Choice)rand.Next(0, 3);
    }

    public static string GetWinner(Player user, Player computer)
    {
        if (user.Choice == computer.Choice)
            return $"Tie! No winners. SCORE You: {user.Score} | AI: {computer.Score}";
        else if ((user.Choice == Choice.Rock && computer.Choice == Choice.Scissors) ||
                 (user.Choice == Choice.Paper && computer.Choice == Choice.Rock) ||
                 (user.Choice == Choice.Scissors && computer.Choice == Choice.Paper))
        {
            user.Score++;
            return $"You win. SCORE You: {user.Score} | AI: {computer.Score}";
        }
        else
        {
            computer.Score++;
            return $"You lost. SCORE You: {user.Score} | AI: {computer.Score}";
        }
    }
}

public class Program
{
    public static void Main()
    {
        Player user = new Player();
        Player ai = new Player();

        while (true)
        {
            Game.GetUserChoice(user);
            Game.ComputerChoice(ai);

            Console.WriteLine($"AI chose: {ai.Choice}");
            Console.WriteLine(Game.GetWinner(user, ai));

            Console.Write("Play again? (y/n): ");
            if (Console.ReadLine().ToLower() != "y") break;
        }

        Console.WriteLine("Good looks for playing!");
    }
}
