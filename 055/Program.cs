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
Average(arr);
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
void Average(int[,]a)
{
    for(int j=0;j<a.GetLength(1);j++)
    {
        double sum=0;
        for (int i=0;i<a.GetLength(0);i++)
        {
            sum+=a[i,j];
        }
        System.Console.WriteLine($"Среднее африфметическое {j}-го столбца = {sum/a.GetLength(0)}");
    }
}



