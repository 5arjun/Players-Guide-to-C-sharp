Console.WriteLine("What is your name sir?");
string name = Console.ReadLine();

int price = 4;

if (name == "june") price /= 2;

Console.WriteLine("The following items are available: " + "\n" + "1 – Rope" + "\n" + "2 - Torches" + "\n" + "3 - Climbing Equipment" + "\n" + "4 - Clean Water" + "\n" + "5 - Machete");
Console.Write("What number do you want to see the price of? ");
int choice = Convert.ToInt32(Console.ReadLine());


string response;
response = choice switch
{
    1 => "the rope is " + price + " dollas",
    2 => "the torch is " + price + " dollas",
    3 => "the climbing equipment is " + price + " dollas",
    4 => "the water is " + price + " dollas",
    5 => "the machete is " + price + "dollas",
    _ => "wrong input bruh"
};
Console.WriteLine(response);
