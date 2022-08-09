// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. 
//Принять первые числа равными 0 и 1

/*
using System;
Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);
*/
using System;
int N = Int32.Parse(Console.ReadLine());
int[] a=new int[N];
int fib1=0;
int fib2=1;
a[0]=fib1;
a[1]=fib2;
a[3]=fib1+fib2;
for (int i=3;i<a.Length;i++)
{
    a[i]=a[i-1]+a[i-2];
}
System.Console.WriteLine(a);