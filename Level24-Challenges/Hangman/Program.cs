using System;
public static class Game
{
    static Random r = new Random();

    public Dictionary<char, int> guessedLetters = new Dictionary<char, int>();
    private string[] words = { "man", "rat", "cow", "chicken" };
    private string word = words[r.Next(0, words.Length)];
    private int remainingGuesses { get; } = 5;


    public string showWord(string word, Dictionary guessedLetters)
    {
        string display = "";
        for (int i = 0; i < word.length; i++)
        {
            if (guessedLetters.ContainsKey(word[i]) == -1 )
                display += word[i];
            else
                display += '_';
        }
        return display;
    }

    public static int takeGuess()
    {
        Console.Write("Guess: ");
        char guess = Console.ReadLine()[0];
        remainingGuesses--;
    }
    public static void displayState()
    {
        Console.WriteLine($"Word: {showWord(word, guessedLetters)} | Remaining: ");
    }
}