// Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
//Найти сумму положительных/отрицательных элементов массива

int N=12;
int[] a=new int[N];              //объявить массив, задать его размер
Random random=new Random();
for(int i=0;i<a.Length;i++)      //цикл for
    a[i]=random.Next(-9,10);     //генерирует случайные числа
int sumPositive=0;
for(int i=0;i<a.Length;i++)
{
    if(a[i]>0)
    {
        sumPositive=sumPositive+a[i];
    }
}

int sumNegative=0;
for(int i=0;i<a.Length;i++)
{
    if(a[i]<0)
    {
        sumNegative=sumNegative+a[i];
    }
}

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}"); 
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма положительных:{sumPositive}");
    System.Console.WriteLine($"Сумма отрицательных:{sumNegative}");
