Console.Write("Enter X value: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y value: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0)
{
    if (y > 0) Console.WriteLine("Enemy is NW");
    if (y == 0) Console.WriteLine("Enemy is W");
    if (y < 0) Console.WriteLine("Enemy is SW");
}
if (x == 0)
{
    if (y > 0) Console.WriteLine("Enemy is N");
    if (y == 0) Console.WriteLine("Enemy is HERE");
    if (y < 0) Console.WriteLine("Enemy is S");
}
if (x < 0)
{
    if (y > 0) Console.WriteLine("Enemy is NE");
    if (y == 0) Console.WriteLine("Enemy is E");
    if (y < 0) Console.WriteLine("Enemy is SE");
}