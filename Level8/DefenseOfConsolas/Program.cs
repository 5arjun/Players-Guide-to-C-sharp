
Console.Title = "Defense of Consolas";

Console.Write("Enter Target Row: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Target Column: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Deploy to:");

Console.WriteLine($"{row}, {col+1}");
Console.WriteLine($"{row+1}, {col}");
Console.WriteLine($"{row}, {col-1}");
Console.WriteLine($"{row-1}, {col}");



