// Дан целочисленный массив. Найти среднее арифметическое каждого 
//из столбцов.

int[,] arr;
int m =Convert.ToInt32(Console.ReadLine());
int n =Convert.ToInt32(Console.ReadLine());
arr=Create2DArray(m,n);

int[,] Create2DArray(int m,int n)
{
    int[,] a=new int[m,n];
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)
        for(int j=0;j<a.GetLength(1);j++)
            a[i,j]=random.Next(0,100);
    return a;
}
Print(arr);
PrintSum(arr);
System.Console.WriteLine();

void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
            for(int j=0;j<a.GetLength(1);j++)
                System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
    }
}
void PrintSum(int[,]a)
{
    int sum = 0;
    for (int i = 0; i < m; i++) 
    {
             for (int j=0; j<n; j++)
        {
             sum += a[i,j];
        } 
    System.Console.WriteLine(sum);
    }
}
/*{
    int sum=0;
    int average=0;
    for (int i=0;i<m;i++)
    {
    for(int j=0;j<n;j++)
        sum+=a[j,i];
        average=sum/n;
       
    }
     System.Console.Write(average);
}*/




/*
a [0,0]
a [1,0]
a [2,0]
int sum=0
sum=a[i,j]+a[i+1,j]
*/