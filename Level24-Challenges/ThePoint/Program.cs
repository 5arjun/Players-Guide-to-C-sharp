using System;

class Point
{
    public int x { get; set; }
    public int y { get; set; }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Point()
    {
        x = 0;
        y = 0;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Point myPoint = new Point(2, 3);
        Point myPoint2 = new Point(-4, 0);

        Console.WriteLine($"Point 1:({myPoint.x},{myPoint.y})");
        Console.WriteLine($"Point 2:({myPoint2.x},{myPoint2.y})");

    }
}

//Answer this question: Are your X and Y properties immutable? Why did you choose what you did?
//they're mutable bc what if i want to change the coordinates of an object
