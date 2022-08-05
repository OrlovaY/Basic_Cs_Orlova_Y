// В Указанном массиве вещественных чисел найдите разницу между максимальным 
//и минимальным элементом
/*
int N=5;
double [] a = new double[N];
Random rand = new Random();
for (int i = 0; i < a.Length; i++)
a[i] = rand.Next(-100, 100) + rand.NextDouble();
System.Console.WriteLine(a);
*/

int N=8;
double[] a=new double[N];              //объявить массив, задать его размер
Random random=new Random();
for(int i=0;i<a.Length;i++)      //цикл for
    a[i]=random.Next(0,100);     //генерирует случайные числа
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}"); 