using System;

public enum Choice { rock, paper, scissors };

public class aPlayer
{
    public int score { get; set; } = 0;
    public Choice choice { get; set; }
}
public static class Game
{
    public static void getUserChoice(aPlayer player)
    {
        while (true)
        {
            Console.Write("Choose rock, paper, or scissors: ");
            if (Enum.TryParse(Console.ReadLine(), true, out player.choice))
                break;
            Console.WriteLine("Invalid choice. Try again.");
        }

    }

    public static void computerChoice(aPlayer computer)
    {
        Random rand = new Random();
        computer.choice = (Choice)rand.Next(0, 3);

    }

    public static string getWinner(aPlayer user, aPlayer computer)
    {
        if (user.choice == computer.choice) return $"Tie! No winners. SCORE You: {user.score} | AI: {computer.score}";
        else if ((user.choice == Choice.Rock && computer.choice == Choice.Scissors) ||
                 (user.choice == Choice.Paper && computer.choice == Choice.Rock) ||
                 (user.choice == Choice.Scissors && computer.choice == Choice.Paper))
        {
            user.score++;
            return $"You win. SCORE You: {user.score} | AI: {computer.score}";
        }
        else
        {
            computer.score++;
            return $"You lost. SCORE You: {user.score} | AI: {computer.score}";
        }
    }
}
public class Program
{
    public static void Main()
    {
        aPlayer user = new aPlayer();
        aPlayer ai = new aPlayer();


        Game.getUserChoice(user);
        Game.computerChoice(ai);
        Console.WriteLine(Game.getWinner(user, ai));
    }
}