int[] user = new int[5];
for (int i = 0; i < user.Length; i++)
{
    Console.WriteLine($"Enter value for spot number {i}");
    user[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copy = new int[5];
for (int i = 0; i < user.Length; i++)
{
    copy[i] = user[i];
}

for (int i = 0; i < user.Length; i++)
{
    Console.WriteLine($"user[{i}] = {user[i]}");
    Console.WriteLine($"copy[{i}] = {user[i]}");
}
