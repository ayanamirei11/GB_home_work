string str;
int a;

Console.WriteLine("Введите первое число");
str = Console.ReadLine();
a=int.Parse(str);

if (a%2==0){
    Console.WriteLine("число "+a+" чётное");
}
else {
    Console.WriteLine("число "+a+" нечётное");
}
