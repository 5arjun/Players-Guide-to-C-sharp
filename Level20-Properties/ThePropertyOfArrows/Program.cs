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
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    public Arrowhead getArrowhead() => _arrowhead;
    public Fletching getFletching() => _fletching;
    public float GetCost()
    {
        float arrowheadCost = arrowhead switch
        {
            Arrowhead.steel => 10,
            Arrowhead.wood => 3,
            Arrowhead.obsidian => 5,
            _ => 0
        };

        float fletchingCost = fletching switch
        {
            Fletching.plastic => 10,
            Fletching.turkey => 5,
            Fletching.goose => 3,
            _ => 0
        };

        return arrowheadCost + fletchingCost + (length * 0.05f);
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

        Console.WriteLine($"Arrowhead: {arrow.getArrowhead()}");
        Console.WriteLine($"Fletching: {arrow.getFletching()}");
    }
}
