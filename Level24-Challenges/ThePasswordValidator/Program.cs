using System;

public static class PasswordValidator
{
 
    public static bool checkLength(string password)
    {
        if (password.Length >= 6 && password.Length <= 13)
            return true;
        return false;
    }

    public static bool checkCaseAndNum(string password)
    {
        int[] count = { 0, 0, 0 };
        foreach (char letter in password)
        {
            if (count[0] == 0 && char.IsLower(letter)) count[0]++;
            if (count[1] == 0 && char.IsUpper(letter)) count[1]++;
            if (count[2] == 0 && char.IsDigit(letter)) count[2]++;
        }//this was done in a stupid way w an arry. i shouldve done it differently.
        return Array.TrueForAll(count, element => element == 1);
    }
    public static bool checkDumbRules(string password)
    {
        bool hasT = false;
        bool hasAnd = false;
        foreach (char letter in password)
        {
            if (letter == 'T') hasT = true;
            if (letter == '&') hasAnd = true;
        }
        if (hasT || hasAnd) return false;
        return true;
    }

    public static bool validatePassword(string password)
    {
        return checkLength(password) && checkCaseAndNum(password) && checkDumbRules(password);
    }
}
public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Write("Enter a password to check: ");
            string password = Console.ReadLine();
            Console.WriteLine($"Is this password valid?  {PasswordValidator.validatePassword(password)}");
        }
    }
}