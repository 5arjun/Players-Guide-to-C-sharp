using System;
public static class Game
{
    static Random r = new Random();

    public static Dictionary<char, int> guessedLetters = new Dictionary<char, int>();
    private static string[] words = { "man", "rat", "cow", "chicken" };
    private static string word = words[r.Next(0, words.Length)];
    private static int remainingGuesses { get; set; } = 5;


    public static string showWord()
    {
        string display = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (guessedLetters.ContainsKey(word[i]))
                display += word[i];
            else
                display += '_';
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

    public static int takeGuess()
    {
        Console.Write("Guess: ");
        char guess = Console.ReadLine()[0];
        remainingGuesses--;
    }
    public static void displayState()
    {
        Console.WriteLine($"Word: {showWord()} | Remaining: | Incorrect: {showIncorrect()}");
    }
}