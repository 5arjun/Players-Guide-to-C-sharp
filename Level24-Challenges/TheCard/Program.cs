using System;

public enum Color { red, green, blue, yellow }
public enum Rank { one, two, three, four, five, six, seven, eight, nine, ten, Ampersand, Percent, Carot, Dollar }

public class Card
{
    public Color color { get; set; }
    public Rank rank { get; set; }

    public Card(Color c, Rank r)
    {
        this.color = c;
        this.rank = r;
    }

    public bool isNumber()
    {
        return rank >= Rank.one && rank <= Rank.ten;
    }
    public bool isSymbol()
    {
        return rank == Rank.Dollar ||
            rank == Rank.Percent ||
            rank == Rank.Carot ||
            rank == Rank.Ampersand;
    }
}

public class Program
{
    public static void Main()
    {
        foreach (Color c in Enum.GetValues(typeof(Color)))
        {
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                Card card = new Card(c, r);

                Console.WriteLine($"The {card.color} {card.rank}");
            }
        }
    }
}