﻿// Console.WriteLine("Enter provinces");
// int provinces = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter Duchies");
// int duchies = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter estates");
// int estates = Convert.ToInt32(Console.ReadLine());

// int point = provinces * 6 + duchies * 3 + estates ;
// Console.WriteLine("The num of points you have is " + point);


Console.WriteLine("Enter provinces");
int point = Convert.ToInt32(Console.ReadLine()) * 6;

Console.WriteLine("Enter Duchies");
point += Convert.ToInt32(Console.ReadLine()) * 3;

Console.WriteLine("Enter estates");
point += Convert.ToInt32(Console.ReadLine());

//int point = provinces * 6 + duchies * 3 + estates ;
Console.WriteLine("The num of points you have is " + point);
