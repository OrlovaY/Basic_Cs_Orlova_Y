//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, 
//если нет, вывести остаток от деления a на b.

int a=23;
int b=5;
int x =a%b;
if (x==0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine("Некратно");
}
if (x>0)
{
    System.Console.WriteLine(x);
}
