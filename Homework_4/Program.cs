﻿//Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("Введите точку x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Растояния между точками равна" +d);