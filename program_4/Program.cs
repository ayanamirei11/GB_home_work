string str;
int a, b, c;

Console.WriteLine("Введите первое число");
str = Console.ReadLine();
a = int.Parse(str);

Console.WriteLine("Введите второе число");
str = Console.ReadLine();
b = int.Parse(str);

Console.WriteLine("Введите третье число");
str = Console.ReadLine();
c = int.Parse(str);

if (a >= b && a >= c)
{
    Console.WriteLine("максимальное: " + a);
}
else if (b >= a && b >= c)
{
    Console.WriteLine("максимальное: " + a);
}
else if (c >= a && c >= b)
{
    Console.WriteLine("максимальное: " + c);
}