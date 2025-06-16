int selected;
do
{
    Console.Write("User 1: Enter a magic number betwwen 1- 100: ");
    selected = Convert.ToInt32(Console.ReadLine());
} while (selected < 1 || selected > 100);


Console.Write("User 2: Guess the number: ");
int choice = Convert.ToInt32(Console.ReadLine());

while (choice != selected)
{
    if (choice < selected)
    {
        Console.WriteLine(choice + " is too low");
        Console.Write("User 2: Guess the number: ");
        choice = Convert.ToInt32(Console.ReadLine());
        continue;
    }

    if (choice > selected)
    {
        Console.WriteLine(choice + " is too high");
        Console.Write("User 2: Guess the number: ");
        choice = Convert.ToInt32(Console.ReadLine());
        continue;
    }
}
Console.WriteLine("congrats jit");




