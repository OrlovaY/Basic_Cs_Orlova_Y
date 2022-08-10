// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
//Принять первые числа равными 0 и 1

using System;
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int[] a=new int[N];
int fib0=0;
System.Console.WriteLine(fib0);
int fib1=1;
System.Console.WriteLine(fib1);
a[0]=fib0;
a[1]=fib1;
a[2]=fib0+fib1;
for (int i=2;i<a.Length;i++)
{
    a[i]=a[i-1]+a[i-2];
    System.Console.WriteLine(a[i]);
}







/*
using System;
Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);
*/