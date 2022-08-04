// Задать массив из 8 целых элементов и вывести их на экран

int N=8;
int[] a=new int[N];              //объявить массив, задать его размер
Random random=new Random();
for(int i=0;i<a.Length;i++)      //цикл for
    a[i]=random.Next(0,100);     //генерирует случайные числа
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i],4}"); 

// Console.WriteLine выведет восемь единиц в столбик
//Console.Write($"{a[i],4}"); запись массива в строку с рассоянием 4 знака между числами

/*
//значимые типы переменных
int a=3;
double b;
float c; 
bool bl;

//ссылочные типы (reference types)

string s;
int[] ar; //массив
Random random;
random=new Random(); 
ar= new int[20];*/
