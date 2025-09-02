using System;

class Color
{
    public int red { get; set; }
    public int green { get; set; }
    public int blue { get; set; }

    public Color(int r, int g, int b)
    {
        red = r;
        green = g;
        blue = b;
    }

    public static Color makeWhite() => new Color(255, 255, 255);
    public static Color makeBlack() => new Color(0, 0, 0);
    public static Color makeRed() => new Color(255, 0, 0);
    public static Color makeGreen() => new Color(0, 128, 0);
    public static Color makeBlue() => new Color(0, 0, 255);
    public static Color makeOrange() => new Color(255, 165, 0);
    public static Color makeYellow() => new Color(255, 255, 0);
    public static Color makePurple() => new Color(128, 0, 128);
}

class Program
{
    static void Main(string[] args)
    {
        Color myColor = new Color(30, 150, 155);
        Color purple = Color.makePurple();

        Console.WriteLine($"myColor values:\n  red-{myColor.red}\n  green-{myColor.green}\n  blue-{myColor.blue}");
        Console.WriteLine($"Purple values:\n  red-{purple.red}\n  green-{purple.green}\n  blue-{purple.blue}");
    }
}