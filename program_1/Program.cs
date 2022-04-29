string str;
int a,b;
Console.WriteLine("Введите число");
str = Console.ReadLine();
a=int.Parse(str);
if (a<0){
    Console.WriteLine(a*-1);
}
else {
    Console.WriteLine(a);
}