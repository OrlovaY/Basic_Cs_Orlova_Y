﻿//Вводится сначала число N, а затем N чисел. 
//Выведите эти N чисел в обратном порядке.
/*
Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ');
for(int i=ss.Length-11;i>=0;i--)
System.Console.WriteLine($"{ss[i]}");
*/

//int N=int.Parse(Console.ReadLine());
using System;
Console.ReadLine();
string s=Console.ReadLine();
string[] ss=s.Split(' ');
for(int i=ss.Length-1;i>=0;i--)
    System.Console.Write($"{ss[i]} ");

