// По двум заданным числам проверять является ли одно квадратом другого. 
//Используйте подпрограмму.

/*
//Сумма двух чисел 
int Sum(int a,int b)
{
    //тело подпрограммы
    return a+b;
}
void Pause() //ожидает нажатия клавиши
{
    return; //досрочно прекратить выполнение
    Console.ReadKey(); ожидает нажатия клавиши
}
//основная программа
int a=Sum(2,2); //вызов подпрограммы
System.Console.WriteLine(Sum(2,4));*/

bool Check(int a, int b)
{
    return a*a==b || b*b==a;
}

int a=25;
int b=5;
if (Check(a,b))
{
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не является");
}