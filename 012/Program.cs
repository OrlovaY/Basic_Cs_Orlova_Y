﻿//С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a=46;
int d1=a/10;//при делении на 10 отбрасывается последняя цифра числа
int d2=a%10;//остаток от деления на 10
int m=Math.Max(d1,d2);
System.Console.WriteLine(m);
