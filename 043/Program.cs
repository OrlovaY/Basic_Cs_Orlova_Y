// С клавиатуры вводится число N. Затем вводятся N чисел. 
//Определить сколько чисел больше 0 введено с клавиатуры

//int N=int.Parse(Console.ReadLine());
using System;
Console.ReadLine();
string s=Console.ReadLine();
string[] ar=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ar,int.Parse);
int countPositive=0;
for (int i=0;i<ar.Length;i++)
{
    if (int.Parse(ar[i])>0)
    {
    countPositive++;
    }
}
System.Console.WriteLine();
System.Console.WriteLine(countPositive);