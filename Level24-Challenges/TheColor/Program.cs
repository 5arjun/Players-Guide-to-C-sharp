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
    public static Color makeOrange() => new Color(255,165,0);
    public static Color makeYellow() => new Color(255,255,0);
    public static Color makePurple() => new Color(128,0,128);



}