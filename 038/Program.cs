// В одномерном массиве из 123 чисел 
//найти количество элементов из отрезка [10,99]

int N=123;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)      
    a[i]=random.Next(0,10);     
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}"); 
System.Console.WriteLine();
   System.Console.WriteLine(a.Length);
