// Показать двумерный массив размером m×n заполненный целыми случайными числами

/*
int[,] a;//объявляем двухмерный массив
//int[,,] 3D; трехмерный массив
//int[,,,] 4D; четырехмерный массив
Arr=Create2DArray(3,4);
a=new int[3,4];//создаем массив
Random random=new Random();
for (int i=0; i<a.GetLength(0);i++)//перебор строк
for (int j=0; j<a.GetLength(0);j++)//перебор столбцов
a[i,j]=random.Next(0,100);
return a;
*/

/*
int[,] arr;//объявляем массив
arr=Create2DArray(3,4);
//int[,] arr2=Create2DArray(4,6);
//Create2DArray2(4,5,out arr);

//1 способ вернуть массив
int[,] Create2DArray(int n,int m)
{
    int[,] a=new int[n,m];//создаем массив
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)//перебираем строки
        for(int j=0;j<a.GetLength(1);j++)//перебираем столбцы
            a[i,j]=random.Next(0,100);
    return a;
}

//2 способ вернуть массив
void Create2DArray2(int n,int m,out int[,] a)
{
    a=new int[n,m];//создаем массив
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)//перебираем строки
        for(int j=0;j<a.GetLength(1);j++)//перебираем столбцы
            a[i,j]=random.Next(0,100);

}
*/

