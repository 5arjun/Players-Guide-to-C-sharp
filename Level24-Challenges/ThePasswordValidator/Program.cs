using System;

public class PasswordValidator
{
    public string password { get; set; }
    private bool isValid { get; set; }

    public bool checkLength(string password)
    {
        if (password.Length >= 6 && password.Length <= 13)
            return true;
        return false;
    }

    public bool checkCaseAndNum(string password)
    {
        int[] count = { 0, 0, 0 };
        foreach (char letter in password)
        {
            if (count[0] == 0 && char.isLower(letter)) count[0]++;
            if (count[1] == 0 && char.isUpper(letter)) count[1]++;
            if (count[2] == 0 && char.isDigit(letter)) count[2]++;
        }//this was done in a stupid way w an arry. i shouldve done it differently.
        return Array.TrueForAll(count, element => element == 1);
    }
    public bool checkDumbRules(string password)
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

    public bool validatePassword(string password)
    {
        return checkLength(password) && checkCaseAndNum(password) && checkDumbRules(password);
    }
}