using System;

enum Arrowhead { steel, wood, obsidian }
enum Fletching { plastic, turkey, goose }

class Arrow
{
    public Arrowhead Arrowhead { get; }
    public Fletching Fletching { get; }
    public float Length { get; }

    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
    {
        Arrowhead = arrowhead;
        Fletching = fletching;
        Length = length;
    }

    public float GetCost()
    {
        float arrowheadCost = Arrowhead switch
        {
            Arrowhead.steel => 10,
            Arrowhead.wood => 3,
            Arrowhead.obsidian => 5,
            _ => 0
        };

        float fletchingCost = Fletching switch
        {
            Fletching.plastic => 10,
            Fletching.turkey => 5,
            Fletching.goose => 3,
            _ => 0
        };

        return arrowheadCost + fletchingCost + (Length * 0.05f);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Vin Fletcher's Arrows!");

        // Get arrowhead choice
        Arrowhead chosenArrowhead;
        while (true)
        {
            Console.Write("Choose arrowhead (steel, wood, obsidian): ");
            if (Enum.TryParse(Console.ReadLine(), true, out chosenArrowhead))
                break;
            Console.WriteLine("Invalid choice. Try again.");
        }

        // Get fletching choice
        Fletching chosenFletching;
        while (true)
        {
            Console.Write("Choose fletching (plastic, turkey, goose): ");
            if (Enum.TryParse(Console.ReadLine(), true, out chosenFletching))
                break;
            Console.WriteLine("Invalid choice. Try again.");
        }

        // Get shaft length
        float chosenLength;
        while (true)
        {
            Console.Write("Enter shaft length in cm: ");
            if (float.TryParse(Console.ReadLine(), out chosenLength) && chosenLength >= 0.1)
                break;
            Console.WriteLine("Invalid length. Must be be greater than 0.1cm.");
        }

        // Create arrow and display cost
        Arrow arrow = new Arrow(chosenArrowhead, chosenFletching, chosenLength);
        Console.WriteLine($"The arrow will cost {arrow.GetCost()} gold coins.");

        Console.WriteLine($"Arrowhead: {arrow.Arrowhead}");
        Console.WriteLine($"Fletching: {arrow.Fletching}");
        Console.WriteLine($"Length: {arrow.Length} cm");
    }
}
