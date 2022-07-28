//С клавиатуры вводятся три числа. Найти максимальное из трех чисел
int a=-110, b=47, c=5;
int max;
if (a>b && a>c)
{
max=a;
System.Console.WriteLine(max);
}
if (b>a && b>c)
{
max=b;
System.Console.WriteLine(max);
}
if (c>a && c>b)
{
    max=c;
    System.Console.WriteLine(max);
}