//Написать программу вывода чисел от 1 до N без использования циклов и оператора goto.
/*
void Loop(int i,int N)
{
    System.Console.WriteLine(i);
    if (i<N) Loop(i+1,N);
}

Loop(1,10);

//Возвести число А в степень числа В
int A=Convert.ToInt32(System.Console.ReadLine());
int B=Convert.ToInt32(System.Console.ReadLine());
int Pow1(int A, int B)
{   
    if (B==0) return 1;
    else
    { 
        return Pow1(A,B-1)*A;
    }

}
System.Console.WriteLine(Pow1(A,B));
*/
//Найти сумму элементов от M до N, N и M заданы 
/*
int S(int m, int n)
{
    if (m < n) return S(m + 1,n) + m;
    else return m;
}
System.Console.WriteLine(S(0,4));
*/
//Найти сумму цифр числа
/*
int sum(int n)
{
    if (n==0) return 0;
    else 
    return n%10+sum(n/10);
    
}
System.Console.WriteLine(sum(22));*/

//Функция Акермана
/*int Accerman(int n, int m)
{
    if (n>=0) return (n+1)+m;
    else 
    return n;

    if (m>=0) return (m+1)+n;
    else 
    return m;    
    
}
System.Console.WriteLine(Accerman(2,2));*/

//Написать программу показывающие первые N чисел, для которых 
//каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем 
//Функция:
int F(int i)
{
    if(i < 1) return num1;
    if(i == 1) return num2;
    return F(i-1) + F(i - 2);
    
}



