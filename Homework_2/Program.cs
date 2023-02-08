//По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Enter first number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = int.Parse(Console.ReadLine());
int sum=a*a;
if (sum!=b)
{
 Console.WriteLine("Не является:"+sum);
}
else if (sum==b)
{
 Console.WriteLine("Является квадратом:"+sum);
}