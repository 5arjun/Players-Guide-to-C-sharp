Console.WriteLine("How many apples were collected?");
int apples = Convert.ToInt32(Console.ReadLine());

int leftover = apples % 4;
Console.WriteLine("The number of leftover apples is: " + leftover);
Console.WriteLine("The number of apples that can be evenly distributed to the sisters is: " + (apples - leftover) / 4);