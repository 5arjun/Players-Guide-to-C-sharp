Console.WriteLine("The following items are available: " + "\n" + "1 – Rope" + "\n" + "2 - Torches" + "\n" + "3 - Climbing Equipment" + "\n" + "4 - Clean Water" + "\n" + "5 - Machete");
Console.Write("What number do you want to see the price of? ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("A rope is a dolla");
        break;
    case 2:
        Console.WriteLine("A torch is a dolla");
        break;
    case 3:
        Console.WriteLine("Climbing equipment is a dolla");
        break;
    case 4:
        Console.WriteLine("Water is a dolla");
        break;
    case 5:
        Console.WriteLine("A machete is a dolla");
        break;
    default:
        Console.WriteLine("Thats not a valid input bruh");
        break;
}
