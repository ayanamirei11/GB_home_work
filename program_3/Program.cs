string str;
int a,b,max,min;

Console.WriteLine("Введите первое число");
str = Console.ReadLine();
a=int.Parse(str);

Console.WriteLine("Введите второе число");
str = Console.ReadLine();
b=int.Parse(str);

if (a>b){
    Console.WriteLine("максимальное: "+a);
    Console.WriteLine("мминимальное: "+b);
}
else if (a==b) {
    Console.WriteLine("числа равные");
}
else {
    Console.WriteLine("максимальное: "+b);
    Console.WriteLine("мминимальное: "+a);
}
