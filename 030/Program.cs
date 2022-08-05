// Написать программу вычисления произведения чисел от 1 до N

int a=1;
int N=10;
int Mult=1;
for (a=1; a<=N; a++)
{
    Mult*=a;
}
System.Console.WriteLine(Mult);