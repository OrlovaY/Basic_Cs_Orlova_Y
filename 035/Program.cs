// Написать программу замены элементов массива на противоположные


int N=8;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-5,8);

int[] b=new int[N];
for(int i=0;i<a.Length;i++)
    b[i]=a[i]*-1;


for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}");
System.Console.WriteLine();
for(int i=0;i<b.Length;i++)
System.Console.Write($"{b[i],4}");