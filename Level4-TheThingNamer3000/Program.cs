//asks for a thing and a description, then prints it out in a specific format
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine();
//string a is the thing, like "sword", "shield", etc.
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine();
//string b is the description, like "big", "azure", "tattered", etc.
string c = "of Doom";
string d = "3000";
/*
string c is the suffix, like "of Doom", "of Destiny", etc.
string d is the number, like "3000", "9000", etc.
*/
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");