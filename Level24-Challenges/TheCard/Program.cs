using System;

enum Color { red, green, blue, yellow }
enum Rank { one, two, three, four, five, six, seven, eight, nine, ten, And, Percent, Carrot, Dollar }

public class Card
{
    public Color color { get; set; }
    public Rank rank { get; set; }

    public Card(Color c, Rank r)
    {
        this.color = c;
        this.rank = r;
    }

    public boolean isNumber()
    {
        return rank >= Rank.one && rank <= Rank.ten;
    }
    public boolean isNumber()
    {
        return rank == Rank.Dollar ||
            rank == Rank.Percent ||
            rank == Rank.Carrot ||
            rank == Rank.And;
    }
}