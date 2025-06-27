// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void Countdown(int x)
{
    Console.WriteLine(x);
    if (x == 0) return;
    Countdown(--x);
}

Countdown(10);