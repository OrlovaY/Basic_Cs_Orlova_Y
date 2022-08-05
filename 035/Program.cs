// Написать программу замены элементов массива на противоположные

int N=10;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)      
    a[i]=random.Next(-10,10);     
for(int i=0;i<a.Length;i++)


for(i=0; i<a.Length; i++)
    a[i]=a[i]*-1;
    System.Console.Write($"{a[i],4}");
System.Console.WriteLine();
