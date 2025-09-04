using System;
public static class Game
{
    static Random r = new Random();

    public static Dictionary<char, int> guessedLetters = new Dictionary<char, int>();
    private static string[] words = { "family", "school", "umbrella", "chickens, gamer, ronaldo, portugal" };
    public static string word = words[r.Next(0, words.Length)];
    public static int remainingGuesses { get; set; } = 5;


    public static string showWord()
    {
        string display = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (guessedLetters.ContainsKey(word[i]))
                display += word[i];
            else
                display += "_ ";
        }
        return display;
    }

    public static string showIncorrect()
    {
        string display = "";
        foreach (char c in guessedLetters.Keys)
        {
            if (word.Contains(c)) continue;
            display += $"{c} ";
        }
        return display.ToUpper();
    }

    public static void takeGuess()
    {
        while (true)
        {
            Console.Write("Guess: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input) || input.Length != 1)
            {
                Console.WriteLine("Please enter a single letter.");
                continue;
            }

            char guess = input[0];

            if (guessedLetters.ContainsKey(guess))
            {
                Console.WriteLine("You already guessed that letter bruh. Try again.");
                continue;
            }

            guessedLetters[guess] = 1;

            if (!word.Contains(guess))
            {
                remainingGuesses--;
            }

            break;
        }
    }

    public static void displayState()
    {
        Console.WriteLine($"Word: {showWord()} | Remaining: {remainingGuesses}| Incorrect: {showIncorrect()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (Game.remainingGuesses > 0 && Game.showWord().Contains('_'))
        {
            Game.displayState();
            Game.takeGuess();
        }

        Game.displayState();

        if (!Game.showWord().Contains('_')) Console.WriteLine("You won!");
        else  Console.WriteLine($"You lost! The word was: {Game.word}");
        
    }
}
