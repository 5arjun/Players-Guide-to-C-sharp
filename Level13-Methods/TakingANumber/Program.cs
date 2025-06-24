int AskForNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int AskForNumberInRange(string text, int min, int max)
{
    int num = Int32.MinValue;
    while (true)
    {
        num = AskForNumber(text);
        if (num < min || num > max)
            num = AskForNumberInRange(text, min, max);
        return num;
    }
}

int number = AskForNumber("Enter a number broski");
Console.WriteLine($"you entered: {number}");

int num2 = AskForNumberInRange("Enter a num betweek 2 and 5 broski", 2, 5);
Console.WriteLine($"you entered: {num2}");
