//Написать программу вычисления функции Аккермана

Console.Write("Введите число n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int n = Convert.ToInt32(Console.ReadLine());
A(m, n);
            
int A(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return A(m - 1, 1);
        if (m > 0 && n > 0) return A(m - 1, A(m, n - 1));
            return A(m,n);
    }
    Console.Write("Результат: ");
    Console.Write(A(m,n));