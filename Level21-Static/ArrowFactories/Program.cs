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

    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.steel, Fletching.plastic, 95);
    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.wood, Fletching.goose, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.steel, Fletching.goose, 65);

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
        Console.WriteLine("Do you want to chose a static arrow (1) or make a custom one (2)?");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Which arrow? \n 1: Elite\n2: Beginner\n3: Marksman");
            int arrowChoice = Convert.ToInt32(Console.ReadLine());
            Arrow yours = null;
            switch (arrowChoice)
            {
                case 1:
                    yours = Arrow.CreateEliteArrow();
                    Console.WriteLine($"The price of your arrow is {yours.GetCost()}");
                    break;
                case 2:
                    yours = Arrow.CreateBeginnerArrow();
                    Console.WriteLine($"The price of your arrow is {yours.GetCost()}");

                    break;
                case 3:
                    yours = Arrow.CreateMarksmanArrow();
                    Console.WriteLine($"The price of your arrow is {yours.GetCost()}");
                    break;
            }

        } else {



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
}
