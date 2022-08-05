// Вывести на экран кубы чисел от 1 до N

int a=1;
int N=5;
double pow = Math.Pow(a,3);
while (a<=N)
    {
        pow = Math.Pow(a,3);
        a++;
        System.Console.WriteLine($"{pow}");
    }
