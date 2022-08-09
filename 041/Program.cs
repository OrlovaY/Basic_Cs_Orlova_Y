// В Указанном массиве вещественных чисел найдите разницу между максимальным 
//и минимальным элементом

int N=8;
double[] a=new double[N];              
Random random=new Random();
for(int i=0;i<a.Length;i++)      
    a[i]=random.Next(0,100)/10.0;     
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],5}"); 
    System.Console.WriteLine();
    //Console.WriteLine("Минимальное значание " + a.Min());
    //Console.WriteLine("Максимальное значение " + a.Max());
    double max=a[0];
for (int i=0;i<a.Length;i++)
    {
        if(a[i]>max)
        {
            max=a[i];
        }
    }
double min=a[0];
for (int i=0;i<a.Length;i++)
{
    if(a[i]<min)
    {
        min=a[i];
    }
}
    System.Console.WriteLine();
    System.Console.WriteLine($"Разница между max и min = {max-min}");

 