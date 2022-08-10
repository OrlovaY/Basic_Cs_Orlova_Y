// Написать программу, которая обменивает элементы первой строки и последней строки

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
System.Console.WriteLine(a.GetLength(0),0);//?
Swap(arr);

void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)// строка
    {
            for(int j=0;j<a.GetLength(1);j++)//столбец
                System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
    }
}


void Swap(int[,] a)
{
    
}



/*
for(int i=0;i<a.GetLength(0)%2;i++)
    {
        a.GetLength(0) a.GetLength(0)-1

     }
     */

//ref int b, ref int c
/*
for(int j=0;j<a.GetLength(1);j++)
    {
        int c = a [0,0];
        int b = a [a.GetLength(1)-1,0];
        int t = c;
    }
    */