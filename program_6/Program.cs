string str;
int n,i;

Console.WriteLine("Введите число");
str = Console.ReadLine();
n=int.Parse(str);

for (i=1; i<=n;i++) {
    if (i%2==0){
        Console.WriteLine(i);
    }   
}