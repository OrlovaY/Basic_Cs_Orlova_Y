// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N=10;
int[] a=new int[N];              
Random random=new Random();
for(int i=0;i<a.Length;i++)      
    a[i]=random.Next(100,1000);
for(int i=0;i<a.Length;i++)    
    System.Console.Write($"{a[i],4}");

int count=0;
for(int i=0; i<a.Length;i++)
{
   if(a[i]%2==0)
   count++;
}

System.Console.WriteLine();
System.Console.Write($"Четных {count}");


int count1=0;
for(int i=0; i<a.Length;i++)
{
   if(a[i]%2!=0)
   count1++;
}
System.Console.WriteLine();
System.Console.WriteLine($"Нечетных {count1}");
