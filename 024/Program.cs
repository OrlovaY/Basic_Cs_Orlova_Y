// Вывести на экран таблицу квадратов чисел от 1 до N

int a=1;
int N=10;
int y=a*a;
while (a<=N)
    {
        y=a*a;
        a=a+1;
        System.Console.Write($"{y,4}");
    }

