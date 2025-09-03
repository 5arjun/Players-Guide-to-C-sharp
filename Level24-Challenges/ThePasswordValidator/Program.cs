using System;

public class PasswordValidator
{
    public string password { get; set; }
    private bool isValid { get; set; }

    public bool checkLength()
    {
        if (password.Length >= 6 && password.Length <= 13)
            return true;
        return false;
    }

    public bool checkCaseAndNum()
    {
        int[] count = { 0, 0, 0 };
        foreach (char letter in password)
        {
            if (count[0] == 0 && char.isLower(letter)) count[0]++;
            if (count[1] == 0 && char.isupper(letter)) count[1]++;
            if (count[2] == 0 && char.isDigit(letter)) count[2]++;
        }
        return Array.TrueForAll(count, element => element == 1);
    }
}