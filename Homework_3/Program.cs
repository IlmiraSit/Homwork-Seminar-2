//Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти: ");
 int a = int.Parse(Console.ReadLine());
 if (a==1)
Console.WriteLine("x>0, y>0");
if (a==2)
Console.WriteLine("x<0, y>0");
if (a==3)
Console.WriteLine("x<0, y<0");
if (a==4)
Console.WriteLine("x>0, y<0");
else
Console.WriteLine("Error!!!");