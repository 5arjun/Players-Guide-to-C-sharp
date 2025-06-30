void DrawLine()
{
    Console.WriteLine("--------------------------------------------------");
}

string status(int round, int city, int manticore)
{
    return $"STATUS: Round: {round} City: {city}/15 Manticore: {manticore}/10\n" +
           $"The cannon is expected to deal {cannonDamage(round)} damage this round.";
}
int cannonDamage (int round)
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        return 5;
    }
    else if (round % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        return 3;
    }
    else if (round % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        return 3;
    }
    else
    {
        Console.ResetColor();
        return 1;
    }
}

bool rangeCheck(int range, int target)
{
    if (range < 1 || range > 100)
    {
        Console.WriteLine("Range must be between 1 and 100. MISS");
        return false;
    }
    if (range < target)
    {
        Console.WriteLine("That round UNDERSHOT the target.");
        return false;
    }
    if (range > target)
    {
        Console.WriteLine("That round OVERSHOT the target.");
        return false;
    }

    if (range == target)
    {
        Console.WriteLine("That round HIT the target!");
        return true;
    }
    return true;
}


int round = 1;
int city = 15;
int manticore = 10;

Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
int target = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Player 2, it is your turn.");
do
{
    DrawLine();
    Console.WriteLine(status(round, city, manticore));
    Console.Write("Enter desired cannon range: ");
    int range = Convert.ToInt32(Console.ReadLine());
    if (rangeCheck(range, target))
    {
        manticore -= cannonDamage(round);
        if (manticore <= 0)
        {
            Console.WriteLine("You have defeated the Manticore!");
        }
    }
    city--;
    if (city <= 0)
    {
        Console.WriteLine("The city has been destroyed!");
    }
    round++;
} while (manticore > 0 && city > 0);